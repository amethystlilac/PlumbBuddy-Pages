<template>
    <v-card
        class="h-100"
    >
        <template
            v-slot:prepend
        >
            <v-icon
                :color="feature.color"
                :icon="feature.icon"
            />
        </template>                    
        <template
            v-slot:title
        >
            <span
                :style="{ color: theme.current.value.colors[feature.color] }"
            >
                {{ feature.name }}
            </span>
        </template>
        <v-parallax
            v-if="feature.image"
            height="300px"
            scale="0.75"
            :src="`/img/${feature.image}`"
        />
        <v-card-text>
            <Markdown
                :source="feature.description"
                class="standard-text"
            />
        </v-card-text>
    </v-card>
</template>

<script setup>
    import { useTheme } from 'vuetify';
    import Markdown from 'vue3-markdown-it';

    const theme = useTheme();

    const { feature } = defineProps({
        feature: Object
    });
</script>
