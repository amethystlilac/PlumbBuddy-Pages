<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Mod Hound'}]"
    />
    <v-container>
        <iframe src="https://www.youtube.com/embed/-cB-HVPN45I" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
        <v-divider />
    </v-container>
    <FeaturePanels
        :features="features"
    />
</template>

<script setup>
    const features = [
        {
            color: 'primary',
            icon: 'mdi-magnify-scan',
            name: 'Another Way to Keep Your Mods Folder Healthy',
            image: 'amphibia-frog-greenery-photo-md.png',
            description: `
[Mod Hound](https://app.ts4modhound.com/) is a website created by [Lumpinou](https://www.patreon.com/lumpinou) so that creators can list their mods, and then players can have their mod folders scanned for things like outdated or broken mods, duplicate files, and missing requirements — a great resource for modders and players alike.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-dog',
            name: 'At the Click of a Button',
            image: 'Nose.png',
            description: `
Mod Hound has partnered with PlumbBuddy to let you run scans on your Mods folder from inside the PlumbBuddy app. A fast and easy way to find and fix problems! With the click of a button, get a report on the state of your mods, usually with convenient buttons to click to fix any issues.
`,
        },
    ];
</script>