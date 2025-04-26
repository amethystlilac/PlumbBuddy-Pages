<template>
    <v-img
        class="mr-4"
        height="76"
        style="float: left;"
        :src="imgSrc"
        width="76"
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
            >
            </v-tooltip>
        </v-chip>
        <v-chip
            v-if="!isWindows"
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
            >
            </v-tooltip>
        </v-chip>
    </p>
</template>

<script setup>
    const { asset, release } = defineProps({
        asset: Object,
        release: Object,
    });
    const isWindows = asset.name.endsWith('.msix');
    const tagParts = release.tag_name.split('/');
    const description = `${isWindows ? `${(asset.name.endsWith('_arm64.msix') ? 'arm64' : 'Intel/AMD x64')}` : 'Universal Binary'} Version ${tagParts[1]} for ${isWindows ? 'Windows 10 or later' : 'macOS Sonoma or later'}`;
    const imgSrc = isWindows ? '@/assets/WindowsLogo.svg' : '@/assets/macOSLogo.png';

</script>