<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Mod Hound'}]"
    />
    <v-container>
        <div class="mx-auto" style="width: 560px;">
			<iframe width="560" height="315" src="https://www.youtube.com/embed/-cB-HVPN45I" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
        </div>
        <v-divider />
        <FeaturePanels
            :features="features"
        />
    </v-container>
</template>

<script setup>
    const features = [
        {
            color: 'primary',
            icon: 'mdi-magnify-scan',
            name: 'Any Mod, Available in Your Language',
            image: 'amphibia-frog-greenery-photo-md.png',
            description: `
[Mod Hound](https://app.ts4modhound.com/) is a website created by [Lumpinou](https://www.patreon.com/lumpinou) so that creators can list their mods, and then players can have their mod folders scanned for things like outdated or broken mods, duplicate files, and missing requirements — a great resource for modders and players alike.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-dog',
            name: 'Easy, Fast, Straightforward',
            image: 'Nose.png',
            description: `
Mod Hound has partnered with PlumbBuddy to let you run scans on your Mods folder from inside the PlumbBuddy app. A fast and easy way to find and fix problems! With the click of a button, get a report on the state of your mods, usually with convenient buttons to click to fix any issues.
`,
        },
    ];
</script>