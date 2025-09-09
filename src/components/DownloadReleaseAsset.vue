<template>
    <v-img
        v-if="isWindows || isMacOs"
        class="mr-4"
        height="76"
        style="float: left;"
        :src="imgSrc"
        width="76"
    />
    <v-icon
        v-if="!(isWindows || isMacOs)"
        class="mr-4"
        color="warning"
        icon="mdi-hand-back-left"
        size="76"
        style="float: left;"
    />
    <p
        class="ma-0"
        style="font-size: 1.2rem;"
    >
        <a
            :href="asset.browser_download_url"
        >
            {{ asset.name }}
        </a>
    </p>
    <p
        class="ma-0"
        style="font-size: 0.9rem"
    >
        {{ description }}
    </p>
    <p
        class="ma-0"
    >
        <v-chip
            v-if="isWindows || isMacOs"
            color="success"
        >
            <v-icon
                class="mr-1"
                icon="mdi-file-sign"
            />
            Code Signed
            <v-tooltip
                activator="parent"
                location="bottom"
                text="This release of PlumbBuddy has been signed with a digital certificate so that you know it hasn't been tampered with."
            />
        </v-chip>
        <v-chip
            v-if="isMacOs"
            color="success"
        >
            <v-icon
                class="mr-1"
                icon="mdi-stamper"
            />
            Notarized
            <v-tooltip
                activator="parent"
                location="bottom"
                text="For added protection, Apple has examined this version of PlumbBuddy and accepted it as safe to run on macOS."
            />
        </v-chip>
        <v-chip
            v-if="!(isWindows || isMacOs)"
            color="warning"
        >
            <v-icon
                class="mr-1"
                icon="mdi-shield-off"
            />
            Not Code Signed
            <v-tooltip
                activator="parent"
                location="bottom"
                text="This release of PlumbBuddy is not or is no longer signed with a digital certificate so that you know it hasn't been tampered with. Use at your own risk"
            />
        </v-chip>
    </p>
</template>

<script setup>
    const { asset, release } = defineProps({
        asset: Object,
        release: Object,
    });
    const isWindows = asset.name.endsWith('.msix');
    const isMacOs = asset.name.endsWith('.zip');
    const tagParts = release.tag_name.split('/');
    const description = `${isWindows ? `${(asset.name.endsWith('_arm64.msix') ? 'arm64' : 'Intel/AMD x64')}` : isMacOs ? 'Universal Binary' : 'No Longer Supported'} Version ${tagParts[1]} for ${isWindows ? 'Windows 10 or later' : isMacOs ? 'macOS Sonoma or later' : 'Historical Purposes'}`;
    const imgSrc = isWindows ? '/img/WindowsLogo.svg' : '/img/macOSLogo.png';
</script>