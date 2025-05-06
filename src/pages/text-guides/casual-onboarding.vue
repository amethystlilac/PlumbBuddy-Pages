<template>
    <MenuToggleBreadcrumbs
        color="secondary"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Starting PlumbBuddy for the First Time'}]"
    />
    <div class="main-container">
        <v-divider />
        <p>
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