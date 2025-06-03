<template>
    <v-container>
        <v-row
            justify="center"
        >
            <v-col
                v-for="guide in guides"
                cols="12"
                sm="6"
            >
                <GuideCard
                    :guide="guide"
                />
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    const { guides } = defineProps({
        guides: Array
    });
</script>