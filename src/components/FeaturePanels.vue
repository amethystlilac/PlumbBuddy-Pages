<template>
    <v-container>
        <v-row
            justify="center"
        >
            <v-col
                v-for="feature in features"
                cols="12"
                sm="6"
            >
                <FeatureCard
                    :feature="feature"
                />
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    const { features } = defineProps({
        features: Array
    });
</script>