<template>
    <v-container
    >
        <v-row
            justify="center"
        >
            <v-col
                v-for="feature in features"
                xs="12"
                lg="6"
            >
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
                    <div
                        v-if="feature.image"
                        :style="{ width: '100%', height: '300px', backgroundImage: `url('/src/assets/${feature.image}')`, backgroundPosition: feature.imagePosition ?? 'center', backgroundSize: 'cover' }"
                    >
                    </div>
                    <v-card-text>
                        <Markdown
                            :source="feature.description"
                            class="standard-text"
                        />
                    </v-card-text>
                </v-card>
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    import { useTheme } from 'vuetify';
    import Markdown from 'vue3-markdown-it';

    const theme = useTheme();

    const { features } = defineProps({
        features: Array
    });
</script>