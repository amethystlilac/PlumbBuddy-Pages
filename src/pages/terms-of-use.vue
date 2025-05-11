<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Terms of Use'}]"
    />
    <v-container>
        <Markdown
            :source="termsOfUseMarkdown"
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import termsOfUseMarkdown from './terms-of-use.md?raw';
</script>