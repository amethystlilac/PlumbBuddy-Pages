<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Archivist'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>Archivist</center>
            <center><img src=/img/treasure-wide.png></img></center>
            <center>Saving Your Saves</center>
        </p>
        <Markdown
            :source="casualArchivistMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualArchivistMarkdown from './casual-archivist.md?raw';
</script>