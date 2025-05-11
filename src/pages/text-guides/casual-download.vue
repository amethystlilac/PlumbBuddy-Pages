<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Downloading and Installing PlumbBuddy'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>Downloading and Installing PlumbBuddy</center>
            <center><img src=/img/DownloadArrowWide.jpeg></img></center>
            <center>The first step to getting PlumbBuddy up and running and helping you it to install it.</center>
        </p>
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