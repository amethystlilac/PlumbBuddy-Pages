<template>
    <v-container
        v-if="!mobile"
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
        v-if="mobile"
        v-for="feature in features"
        class="mt-2"
        :feature="feature"
    />
</template>

<script setup>
    import { useDisplay } from 'vuetify';

    const { mobile } = useDisplay();

    const { features } = defineProps({
        features: Array
    });
</script>