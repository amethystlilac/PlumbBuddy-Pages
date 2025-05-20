<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Manifest Editor for Creators'}]"
    />
    <v-container>
        <v-divider />
        <p>
            <center>Manifest Editor for Creators</center>
            <center>An in-depth guide to what you need to know to get your mods manifested.</center>
        </p>
        <Markdown
            :source="manifestEditorMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import manifestEditorMarkdown from './manifest-editor.md?raw';
</script>