<template>
    <v-card
        class="h-100"
    >
        <div
            :style="`width: 100%; height: 300px; background-image: url('/img/${person.image}'); background-position: ${person.imagePosition ?? 'center'}; background-size: cover;`"
        >
        </div>
        <v-card-title
            :style="`color: ${person.accent};`"
        >
            {{ person.name }}
        </v-card-title>
        <v-card-subtitle
            :style="`color: ${person.accent};`"
        >
            {{ person.title }}
        </v-card-subtitle>
        <v-card-text>
            <Markdown
                :source="person.message"
                class="standard-text"
            />
        </v-card-text>
        <v-card-actions>
            <v-btn
                v-for="button in person.buttons"
                :href="button.href"
                :prepend-icon="button.icon"
                target="_blank"
            >
                {{ button.label }}
                <v-tooltip
                    activator="parent"
                    location="bottom"
                    :text="button.tip"
                />
            </v-btn>
        </v-card-actions>
    </v-card>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';

    const { person } = defineProps({
        person: Object
    });
</script>
