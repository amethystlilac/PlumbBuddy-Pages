<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Archivist'}]"
    />
    <v-container>
        <iframe src="https://www.youtube.com/embed/RGsqfyKJo5g" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
        <p style="font-size:3em;">
            <center>Archivist</center>
        </p>
        <p style="font-size:1.5em;">
            <center>Saving Your Saves</center>
        </p>
        <v-divider />
        <p>
            <center>Jump To:</center>
            <center><a href="#the-vocabulary">The Vocabulary</a> &emsp; <a href="#turning-on-archivist">Turning on Archivist</a> &emsp; <a href="#chronicles">Chronicles</a> &emsp; <a href="#snapshots">Snapshots</a> &emsp; <a href="#live-snapshots-and-mods">Live Snapshots and Mods</a> &emsp; <a href="#searching">Searching</a></center>
        </p>
        <v-divider />
        <Markdown
            :source="ArchivistMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import ArchivistMarkdown from './archivist.md?raw';
</script>