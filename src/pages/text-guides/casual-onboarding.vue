<template>
    <MenuToggleBreadcrumbs
        color="secondary"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'PlumbBuddy First Time Setup'}]"
    />
    <div class="main-container">
        <v-divider />
        <p>
            <center>PlumbBuddy First Time Setup</center>
            <center><img src=/img/ToggleGreenWide.png></img></center>
            <center>Just a few steps to get PlumbBuddy working for you.</center>
        </p>
        <Markdown
            :source="casualOnboardingMarkdown" 
            class="standard-text"
        />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualOnboardingMarkdown from './casual-onboarding.md?raw';
</script>