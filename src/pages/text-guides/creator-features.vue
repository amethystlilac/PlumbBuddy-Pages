<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'The Features'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>The Features</center>
            <center><img src=/img/helping-hand-wide.jpeg></img></center>
            <center>How can PlumbBuddy help you keep your Mods folder healthy?</center>
        </p>
        <v-divider />
        <Markdown
            :source="creatorFeaturesMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import creatorFeaturesMarkdown from './creator-features.md?raw';
</script>