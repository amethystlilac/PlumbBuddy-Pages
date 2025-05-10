<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Mod Hound'}]"
    />
    <div class="main-container">
        <v-divider />
        <p>
            <center>Mod Hound</center>
            <center><img src=/img/ModHoundLogoSm.png></img></center>
            <center>A Different Way to Check Your Mods.</center>
        </p>
        <Markdown
            :source="casualModHoundMarkdown" 
            class="standard-text"
        />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualModHoundMarkdown from './casual-mod-hound.md?raw';
</script>