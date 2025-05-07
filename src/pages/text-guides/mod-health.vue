<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Mod Health'}]"
    />
    <div class="main-container">
        <v-divider />
        <p>
            <center>Mod Health</center>
            <center><img src="/img/nurse-health.jpeg"</center>
            <center>What the Scans Tell You</center>
        </p>
        <Markdown
            :source="ModHealthMarkdown"
            class="standard-text"
        />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import ModHealthMarkdown from './mod-health.md?raw';
</script>