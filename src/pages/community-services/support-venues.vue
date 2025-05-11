<template>
    <MenuToggleBreadcrumbs
        color="tertiary"
        :items="[{title: 'Community Services', to: '/community-services'}, {title: 'Support Venues'}]"
    />
    <v-container>
        <Markdown
            :source="supportVenuesMarkdown" 
            class="standard-text"
        />
        <v-breadcrumbs
            class="pa-0"
            :items="[{title: 'PlumbBuddy-Pages', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages'}, {title: 'public', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages/tree/main/public'}, {title: 'community-data', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages/tree/main/public/community-data'}, {title: 'support-discords.yml', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages/blob/main/public/community-data/support-discords.yml'}, '']"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import supportVenuesMarkdown from './support-venues.md?raw';
</script>
