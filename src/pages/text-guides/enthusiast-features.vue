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
            :source="enthusiastFeaturesMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import enthusiastFeaturesMarkdown from './enthusiast-features.md?raw';
</script>