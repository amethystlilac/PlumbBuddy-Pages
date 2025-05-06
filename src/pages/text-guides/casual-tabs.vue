<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'What can PlumbBuddy do for you?'}]"
    />
    <div class="main-container">
        <v-divider />
        <p>
            <center><img src=/img/helping-hand.jpeg></img></center>
            <center>How can PlumbBuddy help you keep your Mods folder healthy?</center>
        </p>
        <Markdown
            :source="casualTabsMarkdown" 
            class="standard-text"
        />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import casualTabsMarkdown from './casual-tabs.md?raw';
</script>