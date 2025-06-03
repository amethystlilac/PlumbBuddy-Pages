<template>
    <MenuToggleBreadcrumbs
        color="tertiary"
        :items="[{title: 'Community Services', to: '/community-services'}, {title: 'Redirect Hosting'}]"
    />
    <v-container>
        <Markdown
            :source="redirectHostingMarkdown" 
            class="standard-text"
        />
        <v-breadcrumbs
            class="pa-0"
            :items="[{title: 'PlumbBuddy-Pages', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages'}, {title: 'public', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages/tree/main/public'}, {title: 'community-data', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages/tree/main/public/community-data'}, {title: 'redirects.yml', href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages/blob/main/public/community-data/redirects.yml'}, '']"
        />
        <v-data-table
            class="mt-8 mb-4"
            :items="redirects"
            :search="search"
        >
            <template v-slot:top>
                <v-toolbar flat>
                    <v-toolbar-title>
                        <v-icon
                            icon="mdi-share"
                            size="x-small"
                            start
                        />
                        Current Redirects
                    </v-toolbar-title>
                </v-toolbar>
                <v-text-field
                    v-model="search"
                    class="mx-4 mt-4"
                    clearable
                    label="Search"
                    variant="solo-filled"
                />
            </template>
        </v-data-table>
    </v-container>
</template>

<script setup>
    import { ref, onMounted } from 'vue';
    import Markdown from 'vue3-markdown-it';
    import YAML from 'yaml';
    import redirectHostingMarkdown from './redirect-hosting.md?raw';

    const redirects = ref([]);
    const search = ref('');

    onMounted(async () => {
        const yamlObject = YAML.parse(await (await fetch('/community-data/redirects.yml')).text());
        redirects.value = Object.keys(yamlObject).reduce((d, k) => [...d, { name: k, url: yamlObject[k] }], []);
    });
</script>
