<template>
    <v-container>
        <v-row
            justify="center"
        >
            <v-col
                v-for="content in contents"
                cols="7"
                sm="4"
            >
                <ContentCard
                    :content="content"
                />
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    const { contents } = defineProps({
        contents: Array
    });
</script>