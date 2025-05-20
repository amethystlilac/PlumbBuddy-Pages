<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Mod Hound'}]"
    />
    <v-container>
        <iframe src="https://www.youtube.com/embed/-cB-HVPN45I" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
        <p>
            <center>Mod Hound</center>
            <center>A Different Way to Check Your Mods</center>
        </p>
        <Markdown
            :source="casualModHoundMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualModHoundMarkdown from './casual-mod-hound.md?raw';
</script>