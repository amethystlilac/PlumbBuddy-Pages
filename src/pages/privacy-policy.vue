<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Privacy Policy'}]"
    />
    <v-container>
        <Markdown :source="privacyPolicyMarkdown" class="standard-text" />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import privacyPolicyMarkdown from './privacy-policy.md?raw';
</script>