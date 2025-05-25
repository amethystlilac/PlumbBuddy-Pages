<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Manifest Editor for Creators'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center><img src="/img/scaffolding.jpeg" width="400"></img></center>
        </p>
        <p style="font-size:3em;">
            <center>Manifest Editor for Creators</center>
        </p>
        <p style="font-size:1.5em;">
            <center>An in-depth guide to what you need to know to get your mods manifested.</center>
        </p>
        <v-divider />
        <p>
            <center>Jump To:</center>
            <center><a href="#select">Select</a> &emsp; <a href="#details">Details</a> &emsp; <a href="#components">Components</a> &emsp; <a href="#requirements">Requirements</a> &emsp; <a href="#cross-mod">Cross-Mod</a> &emsp; <a href="#hashing">Hashing</a> &emsp; <a href="#confirm">Confirm</a> &emsp; <a href="#providing-support-for-your-mods">Providing Support for Your Mods</a></center>
        </p>
        <v-divider />
        <Markdown
            :source="manifestEditorMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import manifestEditorMarkdown from './manifest-editor.md?raw';
</script>