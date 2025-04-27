<template>
    <v-container
        v-if="!appStore.isPhone"
    >
        <v-row
            justify="center"
        >
            <v-col
                v-for="feature in features"
                xs="12"
                sm="6"
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