<template>
    <v-card
        class="h-100"
    >
        <template
            v-slot:prepend
        >
            <v-icon
                :color="section.color"
                :icon="section.icon"
            />
        </template>                    
        <template
            v-slot:title
        >
            <span
                :style="{ color: theme.current.value.colors[section.color] }"
            >
                {{ section.name }}
            </span>
        </template>
        <div
            :style="{ width: '100%', height: '300px', backgroundImage: `url('/img/${section.image}')`, backgroundPosition: section.imagePosition ?? 'center', backgroundSize: 'cover' }"
        >
        </div>
        <v-card-text>
            <Markdown
                :source="section.description"
                class="standard-text"
            />
        </v-card-text>
        <v-card-actions>
            <v-btn
                :color="section.color"
                :prepend-icon="section.buttonIcon ?? 'mdi-page-next'"
                :to="section.to"
            >
                {{ section.buttonLabel ?? 'Learn More' }}
            </v-btn>
        </v-card-actions>
    </v-card>
</template>

<script setup>
    import { useTheme } from 'vuetify';
    import Markdown from 'vue3-markdown-it';

    const theme = useTheme();

    const { section } = defineProps({
        section: Object
    });
</script>