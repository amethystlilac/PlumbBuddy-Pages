<template>
    <v-container
        v-if="!mobile"
    >
        <v-row
            justify="center"
        >
            <v-col
                v-for="guide in guides"
                xs="12"
                sm="6"
            >
                <GuideCard
                    :guide="guide"
                />
            </v-col>
        </v-row>
    </v-container>
    <GuideCard
        v-if="mobile"
        v-for="guide in guides"
        class="mt-2"
        :guide="guide"
    />
</template>

<script setup>
    import { useDisplay } from 'vuetify';

    const { mobile } = useDisplay();

    const { guides } = defineProps({
        guides: Array
    });
</script>