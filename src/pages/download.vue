<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Download'}]"
    />
    <v-container>
        <div
            v-if="isLoading"
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
        <div
            v-if="!isLoading && goDirectlyToGithub"
            class="d-flex flex-column ga-4"
        >
            <v-alert
                color="warning"
                icon="mdi-network-strength-1-alert"
                text="GitHub is currently experiencing problems that prevent us from reliably showing you details about the latest release of PlumbBuddy from here."
                title="A GitHub API Incident is in Progress"
                variant="tonal"
            />
            <v-btn
                color="primary"
                prepend-icon="mdi-open-in-new"
                to="/redirect?to=LatestGithubRelease"
                variant="tonal"
            >
                Go Directly to GitHub
            </v-btn>
        </div>
        <div
            v-if="!isLoading && !goDirectlyToGithub && globalState.currentRelease.value"
        >
            <p
                v-if="globalState.currentReleaseRecommendedAsset.value"
            >
                I think you want this version based on your computer's operating system:
            </p>
            <p
                v-if="!globalState.currentReleaseRecommendedAsset.value"
            >
                I could not find an ideal download option based on your computer's operating system.
            </p>
            <div
                v-if="globalState.currentReleaseRecommendedAsset.value"
                class="mt-4"
            >
                <DownloadReleaseAsset
                    :release="globalState.currentRelease.value"
                    :asset="globalState.currentReleaseRecommendedAsset.value"
                />
            </div>
            <p
                class="mt-8"
            >
                Other options:
            </p>
            <div
                v-for="otherOption in globalState.currentReleaseRecommendedAsset.value ? globalState.currentRelease.value.assets.filter(asset => asset.name !== globalState.currentReleaseRecommendedAsset.value.name) : globalState.currentRelease.value.assets"
                class="mt-4"
            >
                <DownloadReleaseAsset
                    :release="globalState.currentRelease.value"
                    :asset="otherOption"
                />
            </div>
            <h1
                class="mt-12"
            >
                More information about {{ globalState.currentRelease.value.name }}
            </h1>
            <v-container
                class="pa-0"
            >
                <v-row>
                    <v-col
                        :cols="12"
                        :md="6"
                    >
                        <v-text-field
                            v-model="globalState.currentRelease.value.html_url"
                            class="clickable"
                            hide-details
                            label="Release URL"
                            readonly
                            variant="solo-filled"
                            @click="openGitHubRelease"
                        />
                    </v-col>
                    <v-col 
                        :cols="12"
                        :md="2"
                    >
                        <v-text-field
                            v-model="globalState.currentRelease.value.author.login"
                            class="clickable"
                            hide-details
                            label="Published by"
                            readonly
                            variant="solo-filled"
                            @click="openGitHubUserProfile"
                        />
                    </v-col>
                    <v-col 
                        :cols="12"
                        :md="4"
                    >
                        <v-text-field
                            v-model="globalState.currentReleasePublishedAt.value"
                            hide-details
                            label="Published at"
                            readonly
                            variant="solo-filled"
                        />
                    </v-col>
                </v-row>
            </v-container>
            <Markdown
                :source="globalState.currentReleaseNotes.value"
                class="standard-text"
            />
            <v-divider
                class="my-4"
            />
            <p>
                According to GitHub, PlumbBuddy has been downloaded {{ ('time').toQuantity(globalState.totalDownloadCount.value) }}. Isn't that nifty? Click one of the download links on the top of the page and <strong>🫵 you</strong> could be the {{ (globalState.totalDownloadCount.value + 1).toOrdinalWords() }}! 🎆
            </p>
        </div>
    </v-container>
</template>

<script setup>
    import 'humanizer.node';
    import Markdown from 'vue3-markdown-it';
    import YAML from 'yaml';
    import { useRouter } from 'vue-router';
    import { useGlobalState } from '@/stores/global-state';

    const router = useRouter();
    const globalState = useGlobalState();

    const isLoading = shallowRef(true);
    const goDirectlyToGithub = shallowRef(false);

    onMounted(async () => {
        try {
            const downloadSettings = YAML.parse(await (await fetch('/community-data/website-settings.yml')).text())['download'];
            goDirectlyToGithub.value = downloadSettings.go_directly_to_github;
            if (!downloadSettings.go_directly_to_github) {
                await globalState.loadReleases();
            }
        } finally {
            isLoading.value = false;
        }
    });

    function openGitHubRelease() {
        window.open(globalState.currentRelease.value.html_url, '_blank');
    }

    function openGitHubUserProfile() {
        window.open(globalState.currentRelease.value.author.html_url, '_blank');
    }
</script>