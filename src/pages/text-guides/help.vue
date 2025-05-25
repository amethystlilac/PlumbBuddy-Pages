<template>
    <MenuToggleBreadcrumbs
        color="error"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Help with PlumbBuddy'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center><img src=/img/ConfusedSm.jpeg></img></center>
        </p>
        <p style="font-size:2em;">
            <center>Help with PlumbBuddy</center>
        </p>
        <v-divider />
        <Markdown
            :source="helpMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import helpMarkdown from './help.md?raw';
</script>