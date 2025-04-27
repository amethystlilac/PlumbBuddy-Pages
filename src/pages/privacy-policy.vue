<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Privacy Policy'}]"
    />
    <div class="main-container">
        <Markdown :source="privacyPolicyMarkdown" class="standard-text" />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import privacyPolicyMarkdown from './privacy-policy.md?raw';
</script>