<template>
    <v-card
        :id="guide.id"
        class="h-100"
    >
        <template
            v-slot:prepend
        >
            <v-icon
                :color="guide.color"
                :icon="guide.icon"
            />
        </template>                    
        <template
            v-slot:title
        >
            <span
                :style="{ color: theme.current.value.colors[guide.color] }"
            >
                {{ guide.name }}
            </span>
        </template>
        <v-parallax
            v-if="guide.image"
            height="300px"
            scale="1"
            :src="`/img/${guide.image}`"
        />
        <v-card-text>
            <Markdown
                :source="guide.description"
                class="standard-text"
            />
        </v-card-text>
    </v-card>
</template>

<script setup>
    import { useTheme } from 'vuetify';
    import Markdown from 'vue3-markdown-it';

    const theme = useTheme();

    const { guide } = defineProps({
        guide: Object
    });
</script>