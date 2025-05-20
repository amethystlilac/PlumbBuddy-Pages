<template>
    <MenuToggleBreadcrumbs
        color="secondary"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'PlumbBuddy First Time Setup'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>PlumbBuddy First Time Setup</center>
            <center><img src=/img/ToggleGreenWide.png></img></center>
            <center>A few steps to get PlumbBuddy working for you</center>
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