<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'User Interface Overview'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center><img src=/img/checklistWide.png></img></center>
        </p>
        <p style="font-size:3em;">
            <center>User Interface Overview</center>
        </p>
        <p style="font-size:1.5em;">
            <center>The menus and buttons</center>
        </p>
        <v-divider />
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