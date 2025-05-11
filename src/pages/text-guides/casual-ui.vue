<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'User Interface Overview'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>User Interface Overview</center>
            <center><img src=/img/checklistWide.png></img></center>
            <center>The menus and buttons</center>
        </p>
        <Markdown
            :source="casualUIMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualUIMarkdown from './casual-ui.md?raw';
</script>