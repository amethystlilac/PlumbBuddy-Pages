<template>
    <MenuToggleBreadcrumbs
        color="secondary"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'PlumbBuddy First Time Setup'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center><img src=/img/ToggleGreenWide.png></img></center>
        </p>
        <p style="font-size:3em;">
            <center>PlumbBuddy First Time Setup</center>
        </p>
        <p style="font-size:1.5em;">
            <center>A few steps to get PlumbBuddy working for you</center>
        </p>
        <v-divider />
        <p>
            <center>Jump To:</center>
            <center><a href="#the-legal-stuff">The EULA</a> &emsp; <a href="#themes">Themes</a> &emsp; <a href="#introductions">Introductions</a> &emsp; <a href="#folders">Folders</a> &emsp; <a href="#mod-health">Mod Health</a> &emsp; <a href="#plumbbuddy-settings">PlumbBuddy Settings</a></center>
        </p>
        <Markdown
            :source="creatorOnboardingMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import creatorOnboardingMarkdown from './creator-onboarding.md?raw';
</script>