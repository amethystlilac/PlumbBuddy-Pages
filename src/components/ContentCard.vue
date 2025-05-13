<template>
    <v-card
        class="h-100"
    >
        <template
            v-slot:prepend
        >
            <v-icon
                :color="content.color"
                :icon="content.icon"
            />
        </template>                    
        <template
            v-slot:title
        >
            <span
                :style="{ color: theme.current.value.colors[content.color] }"
            >
                {{ content.name }}
            </span>
        </template>
        <v-parallax
            v-if="content.image"
            height="200px"
            scale=".9"
            :src="`/img/${content.image}`"
        />
        <v-card-text>
            <Markdown
                :source="content.description"
                class="standard-text"
            />
        </v-card-text>
        <v-card-actions>
            <v-btn
                :color="content.color"
                :prepend-icon="content.buttonIcon ?? 'mdi-page-next'"
                :to="content.to"
            >
                {{ content.buttonLabel ?? 'Learn More' }}
            </v-btn>
        </v-card-actions>
    </v-card>
</template>

<script setup>
    import { useTheme } from 'vuetify';
    import Markdown from 'vue3-markdown-it';

    const theme = useTheme();

    const { content } = defineProps({
        content: Object
    });
</script>