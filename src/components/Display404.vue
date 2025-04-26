<template>
    <v-img
        class="rounded-lg mr-4"
        elevation="5"
        height="96"
        src="@/assets/missing_image.png"
        style="float: left;"
        width="96"
    />
    <Markdown
        :source="display404Markdown"
        class="standard-text"
    />
    <v-alert
        class="mt-6"
        type="info"
    >
        You can open my menu to try to find what you're looking for, or <router-link to="/">click here</router-link> to go to my landing page.
    </v-alert>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import display404Markdown from './Display404.md?raw';
</script>