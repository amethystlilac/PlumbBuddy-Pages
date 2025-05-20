<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Parlay'}]"
    />
    <v-container>
        <v-divider />
        <iframe src="https://www.youtube.com/embed/T60_aToD_nM" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
        <p>
            <center>Parlay</center>
            <center>Your Mods in Your Language</center>
        </p>
        <Markdown
            :source="playerParlayMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import playerParlayMarkdown from './player-parlay.md?raw';
</script>