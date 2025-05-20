<template>
    <MenuToggleBreadcrumbs
        color="error"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Help with PlumbBuddy'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>Help with PlumbBuddy</center>
            <center><img src=/img/ConfusedSm.jpeg></img></center>
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