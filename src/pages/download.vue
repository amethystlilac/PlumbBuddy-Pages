<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Download'}]"
    />
    <div class="main-container">
        <div
            v-if="!globalState.currentRelease.value"
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
            v-if="globalState.currentRelease.value"
        >
            I think you want this version based on your computer's operating system:
        </p>
        <div
            class="mt-4"
        >
            <DownloadReleaseAsset
                v-if="globalState.currentReleaseRecommendedAsset.value"
                :release="globalState.currentRelease.value"
                :asset="globalState.currentReleaseRecommendedAsset.value"
            />
        </div>
        <p
            v-if="globalState.currentRelease.value"
            class="mt-8"
        >
            Other options:
        </p>
        <div
            v-if="globalState.currentRelease.value"
            v-for="otherOption in globalState.currentRelease.value.assets.filter(asset => asset.name !== globalState.currentReleaseRecommendedAsset.value.name)"
            class="mt-4"
        >
            <DownloadReleaseAsset
                v-if="globalState.currentReleaseRecommendedAsset.value"
                :release="globalState.currentRelease.value"
                :asset="otherOption"
            />
        </div>
        <h1
            v-if="globalState.currentRelease.value"
            class="mt-12"
        >
            More information about {{ globalState.currentRelease.value.name }}
        </h1>
        <v-container
            v-if="globalState.currentRelease.value"
            class="pa-0"
        >
            <v-row
                no-gutters
            >
                <v-col 
                    cols="7"
                >
                    <v-text-field
                        v-model="globalState.currentRelease.value.html_url"
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
                        v-model="globalState.currentRelease.value.author.login"
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
                        v-model="globalState.currentReleasePublishedAt.value"
                        label="Published at"
                        readonly
                        variant="solo-filled"
                    />
                </v-col>
            </v-row>
        </v-container>
        <Markdown
            v-if="globalState.currentReleaseNotes.value"
            :source="globalState.currentReleaseNotes.value"
            class="standard-text"
        />
        <v-divider
            v-if="globalState?.totalDownloadCount?.value"
            class="my-4"
        />
        <p
            v-if="globalState?.totalDownloadCount?.value"
        >
            According to GitHub, PlumbBuddy has been downloaded {{ ('time').toQuantity(globalState.totalDownloadCount.value) }}. Isn't that nifty? Click one of the download links on the top of the page and <strong>🫵 you</strong> could be the {{ (globalState.totalDownloadCount.value + 1).toOrdinalWords() }}! 🎆
        </p>
    </div>
</template>

<script setup>
    import 'humanizer.node';
    import { onMounted } from 'vue';
    import Markdown from 'vue3-markdown-it';
    import { useGlobalState } from '@/stores/global-state';

    const globalState = useGlobalState();

    onMounted(async () => {
        await globalState.loadReleases();
    });

    function openGitHubRelease() {
        window.open(globalState.currentRelease.value.html_url, '_blank');
    }

    function openGitHubUserProfile() {
        window.open(globalState.currentRelease.value.author.html_url, '_blank');
    }
</script>