import dayjs from 'dayjs';
import { defineStore } from 'pinia';

let releasesLoaded = false;

export const useAppStore = defineStore('app', {
    state: () => ({
        currentRelease: null,
        isDesktop: false,
        isPhone: false,
        isTablet: false,
        releases: [],
        totalDownloadCount: 0,
    }),

    actions: {
        detectDeviceTypes() {
            const w = window.innerWidth;
            this.isPhone = w < 600;
            this.isTablet = w >= 600 && w < 1200;
            this.isDesktop = w >= 1200;
        },

        async loadReleases() {
            if (releasesLoaded) {
                return;
            }
            await this.refreshReleases();
        },

        async refreshReleases() {
            releasesLoaded = true;
            let releases = [];
            let lastPageSize = 1;
            let pageNum = 0;
            while (lastPageSize > 0) {
                const page = await (await fetch(`https://api.github.com/repos/Llama-Logic/PlumbBuddy/releases?page=${++pageNum}`)).json();
                lastPageSize = page.length;
                const releaseIds = releases.map(release => release.id);
                releases = [...releases, ...page.filter(release => !releaseIds.includes(release.id))];
            }
            releases.sort((a, b) => dayjs(b.published_at).valueOf() - dayjs(a.published_at).valueOf());
            this.releases = releases;
            const totalDownloadCount = releases
                .map(release => release.assets)
                .reduce((allAssets, assets) => [...allAssets, ...assets], [])
                .map(asset => asset.download_count)
                .reduce((sum, downloadCount) => sum + downloadCount, 0);
            this.totalDownloadCount = totalDownloadCount;
            if (releases.length) {
                this.currentRelease =
                    releases.find(r => r.tag_name.startsWith('release/'))
                    ?? releases.find(r => r.tag_name.startsWith('release-preview/'))
                    ?? releases.find(r => r.tag_name.startsWith('release-beta/'))
                    ?? releases.find(r => r.tag_name.startsWith('release-alpha/'));
            }
        },
    }
})
