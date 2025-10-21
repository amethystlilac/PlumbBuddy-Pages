<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'The Features'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center><img src=/img/helping-hand-wide.jpeg></img></center>
        </p>
        <p style="font-size:3em;">
            <center>The Features</center>
        </p>
        <p style="font-size:1.5em;">
            <center>How can PlumbBuddy help you keep your Mods folder healthy?</center>
        </p>
        <v-divider />
        <p>
            <center>Jump To:</center>
            <center><a href="#mod-health">Mod Health</a> &emsp; <a href="#personal-notes">Personal Notes</a> &emsp; <a href="#catalog">Catalog</a> &emsp; <a href="#mod-hound">Mod Hound</a> &emsp; <a href="#archivist">Archivist</a> &emsp; <a href="#parlay">Parlay</a> &emsp; <a href="#pack-selector">Pack Selector</a></center>
        </p>
        <v-divider />
        <Markdown
            :source="casualFeaturesMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualFeaturesMarkdown from './casual-features.md?raw';
</script>