<template>
    <v-container
        v-if="!appStore.isPhone"
    >
        <v-row
            justify="center"
            class="ga-4"
        >
            <v-col
                v-for="feature in features"
                class="ma-0 pa-0"
                xs="12"
                lg="6"
            >
                <FeatureCard
                    :feature="feature"
                />
            </v-col>
        </v-row>
    </v-container>
    <FeatureCard
        v-if="appStore.isPhone"
        v-for="feature in features"
        class="mt-2"
        :feature="feature"
    />
</template>

<script setup>
    import { useAppStore } from '@/stores/app';

    const appStore = useAppStore();

    const { features } = defineProps({
        features: Array
    });
</script>