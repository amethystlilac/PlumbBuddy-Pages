<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'The Features'}]"
    />
    <div class="main-container">
        <v-divider />
        <p>
            <center>The Features</center>
            <center><img src=/img/helping-hand-wide.jpeg></img></center>
            <center>How can PlumbBuddy help you keep your Mods folder healthy?</center>
        </p>
        <v-divider />
        <Markdown
            :source="casualFeaturesMarkdown" 
            class="standard-text"
        />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualFeaturesMarkdown from './casual-features.md?raw';
</script>