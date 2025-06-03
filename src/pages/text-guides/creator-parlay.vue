<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Parlay'}]"
    />
    <v-container>
        <iframe src="https://www.youtube.com/embed/T60_aToD_nM" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
        <p style="font-size:3em;">
            <center>Parlay</center>
        </p>
        <p style="font-size:1.5em;">
            <center>Your Mods in Your Language</center>
        </p>
        <v-divider />
        <p>
            <center>Jump To:</center>
            <center><a href="#messages-to-translators">Messages to Translators</a> &emsp; <a href="#integration">Integration</a> &emsp; <a href="#crediting-a-translator-who-didn't-use-parlay">Crediting a Translator Who Didn't Use Parlay</a></center>
        </p>
        <v-divider />
        <Markdown
            :source="creatorParlayMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import creatorParlayMarkdown from './creator-parlay.md?raw';
</script>