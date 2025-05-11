<template>
    <v-img
        class="rounded-lg mr-4 ml-3 mt-5"
        elevation="5"
        height="96"
        src="/img/missing_image.png"
        style="float: left;"
        width="96"
    />
    <Markdown
        :source="display404Markdown"
        class="standard-text"
    />
    <div
        class="d-flex align-center mt-4 ga-4"
    >
        <v-alert
            class="flex-grow-1"
            type="info"
        >
            You can open my menu to try to find what you're looking for, or <router-link to="/">click here</router-link> to go to my landing page.
        </v-alert>
        <v-tooltip
            text="Debug link locally"
        >
            <template
                v-slot:activator="{ props }"
            >
                <v-btn
                    v-bind="props"
                    @click="debugLinkLocally"
                >
                    <v-icon
                        icon="mdi-debug-step-over"
                    />
                </v-btn>
            </template>
        </v-tooltip>
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import display404Markdown from './Display404.md?raw';

    function debugLinkLocally() {
        debugger;
        window.location.href = `http://localhost:3000${window.location.pathname}${window.location.search}${window.location.hash}`;
    }
</script>