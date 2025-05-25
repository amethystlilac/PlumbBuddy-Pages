<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Downloading and Installing PlumbBuddy'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center><img src=/img/DownloadArrowWide.jpeg></img></center>
        </p>
        <p style="font-size:3em">
            <center>Downloading and Installing PlumbBuddy</center>
        </p>
        <p style="font-size:1.5em">
            <center>The first step to getting PlumbBuddy up and running and helping you is to install it.</center>
        </p>
        <v-divider />
        <p>
            <center>Jump To:</center>
            <center><a href="#downloading">Downloading</a> &emsp; <a href="#installing-on-windows">Installing on Windows</a> &emsp; <a href="#installing-on-mac">Installing on Mac</a></center>
        </p>
        <v-divider />
        <Markdown
            :source="casualDownloadMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualDownloadMarkdown from './casual-download.md?raw';
</script>