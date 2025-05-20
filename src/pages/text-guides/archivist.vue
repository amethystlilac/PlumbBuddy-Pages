<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Archivist'}]"
    />
    <v-container>
        <iframe src="https://www.youtube.com/embed/RGsqfyKJo5g" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
        <p>
            <center>Archivist</center>
            <center>Saving Your Saves</center>
        </p>
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