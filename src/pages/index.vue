<template>
    <MenuToggleBreadcrumbs />
    <v-container
    >
        <v-row>
            <v-col
                :cols="12"
                :md="8"
            >
                <v-card
                    color="primary"
                    prepend-avatar="/img/RasterizedLogo.png"
                    subtitle="Improved experience with The Sims 4."
                    title="Welcome to PlumbBuddy"
                >
                    <v-card-actions>
                        <v-btn
                            prepend-icon="mdi-feature-search"
                            text="Learn More About Features"
                            to="/features"
                        />
                        <v-spacer />
                        <v-btn
                            prepend-icon="mdi-book-alphabet"
                            text="Read Full Guides"
                            to="/text-guides"
                        />
                        <v-spacer />
                        <v-btn
                            href="https://discord.gg/XKbMEEfRde"
                            :prepend-icon="['M22,24L16.75,19L17.38,21H4.5A2.5,2.5 0 0,1 2,18.5V3.5A2.5,2.5 0 0,1 4.5,1H19.5A2.5,2.5 0 0,1 22,3.5V24M12,6.8C9.32,6.8 7.44,7.95 7.44,7.95C8.47,7.03 10.27,6.5 10.27,6.5L10.1,6.33C8.41,6.36 6.88,7.53 6.88,7.53C5.16,11.12 5.27,14.22 5.27,14.22C6.67,16.03 8.75,15.9 8.75,15.9L9.46,15C8.21,14.73 7.42,13.62 7.42,13.62C7.42,13.62 9.3,14.9 12,14.9C14.7,14.9 16.58,13.62 16.58,13.62C16.58,13.62 15.79,14.73 14.54,15L15.25,15.9C15.25,15.9 17.33,16.03 18.73,14.22C18.73,14.22 18.84,11.12 17.12,7.53C17.12,7.53 15.59,6.36 13.9,6.33L13.73,6.5C13.73,6.5 15.53,7.03 16.56,7.95C16.56,7.95 14.68,6.8 12,6.8M9.93,10.59C10.58,10.59 11.11,11.16 11.1,11.86C11.1,12.55 10.58,13.13 9.93,13.13C9.29,13.13 8.77,12.55 8.77,11.86C8.77,11.16 9.28,10.59 9.93,10.59M14.1,10.59C14.75,10.59 15.27,11.16 15.27,11.86C15.27,12.55 14.75,13.13 14.1,13.13C13.46,13.13 12.94,12.55 12.94,11.86C12.94,11.16 13.45,10.59 14.1,10.59Z']"
                            text="Join Our Discord"
                        />
                    </v-card-actions>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="success"
                    prepend-icon="mdi-download"
                    subtitle="For Windows and macOS."
                    title="Download Now!"
                    to="/download"
                >
                    <v-card-actions>
                        <v-btn
                            prepend-icon="mdi-currency-usd-off"
                            text="Always Free of Cost and Ads"
                        />
                    </v-card-actions>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="grey"
                    prepend-icon="mdi-laptop"
                    subtitle="PlumbBuddy runs wherever The Sims 4 does."
                    title="Multiplatform Support"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        As long as it's a computer that EA supports for The Sims 4, it can also run PlumbBuddy.
                        From desktops to laptops, from Windows to macOS.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="#DAA520"
                    prepend-icon="mdi-power-plug-battery"
                    subtitle="PlumbBuddy uses only what it needs."
                    title="Resource and Power Efficient"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        PlumbBuddy was specifically engineered to use minimal resources and energy on your computer, so it's safe to keep running in the background.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="green"
                    prepend-icon="mdi-security"
                    subtitle="PlumbBuddy is safe and respects privacy."
                    title="Open Source &amp; Digitally Signed"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        PlumbBuddy contains no ads, no tracking, and no malware.
                        The code inside is publicly available.
                        Every release is authenticated by Microsoft and Apple.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="primary"
                    prepend-icon="mdi-bottle-tonic-plus"
                    subtitle="PlumbBuddy's always on the job."
                    title="Monitors for Problems &amp; Helps"
                    to="/features/mod-health"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        PlumbBuddy continuously watches The Sims 4 for mod installation and config issues.
                        The app starts automatically on PCs and can be launched on Macs.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="primary"
                    prepend-icon="mdi-dog"
                    subtitle="PlumbBuddy is integrated with Mod Hound."
                    title="Checks for Mod Updates"
                    to="/features/mod-hound"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        Many mod creators register their mod updates with Lumpinou's Mod Hound.
                        You can use PlumbBuddy to quickly fetch Mod Hound reports for your mods.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="primary"
                    prepend-icon="mdi-bag-personal-tag"
                    subtitle="PlumbBuddy can toggle installed packs."
                    title="Picks Your Packs with Ease"
                    to="/features/pack-selector"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        The in-game Pack Selector tool has caused problems for some.
                        PlumbBuddy offers a convenient interface for doing the same thing.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="secondary"
                    prepend-icon="mdi-archive-clock"
                    subtitle="PlumbBuddy can safeguard your save games."
                    title="Backs Up and Manages Saves"
                    to="/features/archivist"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        PlumbBuddy can put your save games in a safe place you choose, with compression that feels like magic.
                        Make notes, search, manage timelines.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="secondary"
                    prepend-icon="mdi-translate-variant"
                    subtitle="PlumbBuddy has side-by-side translation."
                    title="Translates to Any Language"
                    to="/features/parlay"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        If a mod doesn't support a language you wish it did, PlumbBuddy has a feature-rich tool you can use to easily make a translation for it.
                    </v-card-text>
                </v-card>
            </v-col>
            <v-col
                :cols="12"
                :md="4"
            >
                <v-card
                    color="tertiary"
                    prepend-icon="mdi-access-point-network"
                    subtitle="PlumbBuddy offers services to mod creators."
                    title="Enhances Modded Gameplay"
                    to="/features/runtime-mod-integration"
                    :variant="vCardVariant"
                >
                    <v-card-text
                        :class="vCardTextClass"
                    >
                        With PlumbBuddy, your mods gain the abilities to show customized user interfaces, use alternative input devices, and lessen their performance impact.
                    </v-card-text>
                </v-card>
            </v-col>
        </v-row>
        <v-row
            v-if="globalState.currentReleaseVersion.value && globalState.currentReleaseLifecycleStageName.value"
        >
            <v-col
                :cols="6"
            >
                <v-alert
                    density="compact"
                    icon="mdi-application"
                    variant="tonal"
                >
                    <span v-if="!xs">Current version: </span>
                    <strong>{{ globalState.currentReleaseVersion.value }}</strong>
                </v-alert>
            </v-col>
            <v-col
                :cols="6"
            >
                <v-alert
                    :color="globalState.currentReleaseLifecycleStageThemeColor.value"
                    density="compact"
                    :icon="globalState.currentReleaseLifecycleStageIcon.value"
                    variant="tonal"
                >
                    <span v-if="!xs">Lifecycle stage: </span>
                    <strong>{{ globalState.currentReleaseLifecycleStageName.value }}</strong>
                </v-alert>
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    import { useDisplay } from 'vuetify';
    import { useGlobalState } from '@/stores/global-state';

    const globalState = useGlobalState();

    const { xs } = useDisplay();

    const vCardVariant = shallowRef('outlined')
    const vCardTextClass = shallowRef('');

    const mediaQuery = window.matchMedia('(prefers-color-scheme: dark)');

    function updateTheme() {
        const prefersDark = mediaQuery.matches;
        vCardVariant.value = prefersDark ? 'tonal' : 'outlined';
        vCardTextClass.value = prefersDark ? 'bg-surface pt-4' : '';
    }

    onMounted(async () => {
        updateTheme();
        mediaQuery.addEventListener('change', updateTheme);
        await globalState.loadReleases();
    });

    onBeforeUnmount(() => {
        mediaQuery.removeEventListener('change', updateTheme);
    });

</script>

<style scoped>

</style>