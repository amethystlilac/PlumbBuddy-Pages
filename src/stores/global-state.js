import { computed, shallowRef } from 'vue'
import { asyncComputed, createGlobalState } from '@vueuse/core'
import dayjs from 'dayjs';
import localizedFormat from 'dayjs/plugin/localizedFormat';
import utc from 'dayjs/plugin/utc';
import platform from 'platform';

export const useGlobalState = createGlobalState(() => {
    dayjs.extend(utc);
    dayjs.extend(localizedFormat);
    dayjs.locale(navigator.language || 'en');

    const isMenuOpen = shallowRef(false);

    const releases = shallowRef(null);

    const currentRelease = computed(() => {
        const loadedReleases = releases.value ?? [];
        if (!loadedReleases.length) {
            return null;
        }
        return loadedReleases.find(r => r.tag_name.startsWith('release/'))
            ?? loadedReleases.find(r => r.tag_name.startsWith('release-preview/'))
            ?? loadedReleases.find(r => r.tag_name.startsWith('release-beta/'))
            ?? loadedReleases.find(r => r.tag_name.startsWith('release-alpha/'));
    });

    const currentReleaseNotes = computed(() => currentRelease.value ? currentRelease.value.body : null);

    const currentReleasePublishedAt = computed(() => currentRelease.value ? dayjs.utc(currentRelease.value.published_at).local().format('LLLL') : null);

    const currentReleaseRecommendedAsset = asyncComputed(async () => {
        if (!currentRelease.value) {
            return null;
        }
        const isWindows = (platform.os?.family ?? 'Unknown') === 'Windows';
        if (isWindows) {
            let instructionSetSuffix = '_x64.msix';
            if (navigator.userAgentData) {
                const userAgent = await navigator.userAgentData.getHighEntropyValues([
                    "architecture",
                    "bitness"
                ]);
                if (userAgent.architecture === 'arm' && userAgent.bitness === '64') {
                    instructionSetSuffix = '_arm64.msix';
                }
            }
            return currentRelease.value.assets.find(asset => asset.name.endsWith(instructionSetSuffix))
                ?? currentRelease.value.assets.find(asset => asset.name.endsWith('.msix'));
        } else {
            return currentRelease.value.assets.find(asset => asset.name.endsWith('.zip'));
        }
    });

    const currentReleaseTagParts = computed(() => currentRelease.value ? currentRelease.value.tag_name.split('/') : null);

    const currentReleaseLifecycleStageThemeColor = computed(() => {
        const tagParts = currentReleaseTagParts.value;
        if (!tagParts) {
            return null;
        }
        const root = tagParts[0];
        return root === 'release-alpha' ? 'error'
             : root === 'release-beta' ? 'warning'
             : root === 'release-preview' ? 'info'
             : root === 'release' ? 'success'
             : null;
    });

    const currentReleaseLifecycleStageIcon = computed(() => {
        const tagParts = currentReleaseTagParts.value;
        if (!tagParts) {
            return null;
        }
        const root = tagParts[0];
        return root === 'release-alpha' ? 'mdi-alpha'
             : root === 'release-beta' ? 'mdi-beta'
             : root === 'release-preview' ? 'mdi-certificate-outline'
             : root === 'release' ? 'mdi-certificate'
             : null;
    });

    const currentReleaseLifecycleStageName = computed(() => {
        const tagParts = currentReleaseTagParts.value;
        if (!tagParts) {
            return null;
        }
        const root = tagParts[0];
        return root === 'release-alpha' ? 'Alpha'
             : root === 'release-beta' ? 'Beta'
             : root === 'release-preview' ? 'Preview'
             : root === 'release' ? 'Stable'
             : null;
    });

    const currentReleaseVersion = computed(() => {
        const tagParts = currentReleaseTagParts.value;
        if (!tagParts) {
            return null;
        }
        const version = tagParts[1];
        return version ? version : null;
    });

    const totalDownloadCount = computed(() => (releases.value ?? [])
        .map(release => release.assets)
        .reduce((allAssets, assets) => [...allAssets, ...assets], [])
        .map(asset => asset.download_count)
        .reduce((sum, downloadCount) => sum + downloadCount, 0));

    async function loadReleases() {
        if (!currentRelease.value) {
            await refreshReleases();
        }
    }

    async function refreshReleases() {
        let loadedReleases = [];
        let lastPageSize = 1;
        let pageNum = 0;
        while (lastPageSize > 0) {
            const page = await (await fetch(`https://api.github.com/repos/Llama-Logic/PlumbBuddy/releases?page=${++pageNum}`)).json();
            lastPageSize = page.length;
            const releaseIds = loadedReleases.map(release => release.id);
            loadedReleases = [...loadedReleases, ...page.filter(release => !releaseIds.includes(release.id))];
        }
        loadedReleases.sort((a, b) => dayjs(b.published_at).valueOf() - dayjs(a.published_at).valueOf());
        releases.value = loadedReleases;
    }

    function setIsMenuOpen(newIsMenuOpen) {
        isMenuOpen.value = newIsMenuOpen;
    }

    return {
        currentRelease,
        currentReleaseLifecycleStageThemeColor,
        currentReleaseLifecycleStageIcon,
        currentReleaseLifecycleStageName,
        currentReleaseNotes,
        currentReleasePublishedAt,
        currentReleaseRecommendedAsset,
        currentReleaseVersion,
        isMenuOpen,
        loadReleases,
        refreshReleases,
        releases,
        setIsMenuOpen,
        totalDownloadCount,
    };
});