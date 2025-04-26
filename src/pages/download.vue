<template>
    <v-breadcrumbs
        bg-color="success"
        :items="[{title: 'PlumbBuddy.app', to: '/'}, {title: 'Download'}]"
    />
    <div class="main-container">
        <div
            v-if="!currentRelease"
            class="mx-auto"
            style="width: 150px;"
        >
            <v-progress-circular
                class="mx-auto"
                color="success"
                indeterminate
                :size="150"
                width="15"
            >
                <v-icon
                    color="success"
                    icon="mdi-cloud-download"
                    size="72"
                />
            </v-progress-circular>
        </div>
        <p
            v-if="currentRelease"
        >
            I think you want this version based on your computer's operating system:
        </p>
        <div
            class="mt-4"
        >
            <DownloadReleaseAsset
                v-if="recommendAsset"
                :release="currentRelease"
                :asset="recommendAsset"
            />
        </div>
        <p
            v-if="currentRelease"
            class="mt-8"
        >
            Other options:
        </p>
        <div
            v-if="currentRelease"
            v-for="otherOption in currentRelease.assets.filter(asset => asset.name !== recommendAsset.name)"
            class="mt-4"
        >
            <DownloadReleaseAsset
                v-if="recommendAsset"
                :release="currentRelease"
                :asset="otherOption"
            />
        </div>
        <h1
            v-if="currentRelease"
            class="mt-12"
        >
            More information about {{ currentRelease.name }}
        </h1>
        <v-container
            v-if="currentRelease"
            class="pa-0"
        >
            <v-row
                no-gutters
            >
                <v-col 
                    cols="7"
                >
                    <v-text-field
                        v-model="currentRelease.html_url"
                        class="mr-4 clickable"
                        label="Release URL"
                        readonly
                        variant="solo-filled"
                        @click="openGitHubRelease"
                    />
                </v-col>
                <v-col 
                    cols="2"
                >
                    <v-text-field
                        v-model="currentRelease.author.login"
                        class="mr-4 clickable"
                        label="Published by"
                        readonly
                        variant="solo-filled"
                        @click="openGitHubUserProfile"
                    />
                </v-col>
                <v-col 
                    cols="3"
                >
                    <v-text-field
                        v-model="publishedAt"
                        label="Published at"
                        readonly
                        variant="solo-filled"
                    />
                </v-col>
            </v-row>
        </v-container>
        <Markdown
            :source="releaseNotes"
            class="standard-text"
        />
        <v-divider
            v-if="currentRelease"
            class="my-4"
        />
        <p
            v-if="currentRelease"
        >
            According to GitHub, PlumbBuddy has been downloaded {{ ('time').toQuantity(totalDownloadCount) }}. Isn't that nifty? Click one of the download links on the top of the page and <strong>🫵 you</strong> could be the {{ (totalDownloadCount + 1).toOrdinalWords() }}! 🎆
        </p>
    </div>
</template>

<script setup>
    import dayjs from 'dayjs';
    import localizedFormat from 'dayjs/plugin/localizedFormat';
    import 'humanizer.node';
    import platform from 'platform';
    import utc from 'dayjs/plugin/utc';
    import { ref, onMounted } from 'vue';
    import Markdown from 'vue3-markdown-it';
    import { useAppStore } from '@/stores/app';

    dayjs.extend(utc);
    dayjs.extend(localizedFormat);
    dayjs.locale(navigator.language || 'en');

    const appStore = useAppStore();
    const currentRelease = ref(null);
    const publishedAt = ref('');
    const releaseNotes = ref('');
    const recommendAsset = ref(null);
    const totalDownloadCount = ref(0);

    onMounted(async () => {
        await appStore.loadReleases();
        currentRelease.value = appStore.currentRelease;
        publishedAt.value = currentRelease.value ? dayjs.utc(currentRelease.value.published_at).local().format('LLLL') : '';
        releaseNotes.value = currentRelease.value ? currentRelease.value.body : '';
        recommendAsset.value = currentRelease.value ? (function() {
            const isWindows = (platform.os?.family ?? 'Unknown') === 'Windows';
            if (isWindows) {
                const instructionSetSuffix = /\barm64\b/i.test(platform.ua) ? '_arm64.msix' : '_x64.msix';
                return currentRelease.value.assets.find(asset => asset.name.endsWith(instructionSetSuffix))
                    ?? currentRelease.value.assets.find(asset => asset.name.endsWith('.msix'))
                    ?? currentRelease.value.assets[0];
            } else {
                return currentRelease.value.assets.find(asset => asset.name.endsWith('.zip'))
                    ?? currentRelease.value.assets[0];
            }
        }()) : null;
        totalDownloadCount.value = appStore.totalDownloadCount;
    });

    function openGitHubRelease() {
        window.open(currentRelease.value.html_url, '_blank');
    }

    function openGitHubUserProfile() {
        window.open(currentRelease.value.author.html_url, '_blank');
    }
</script>