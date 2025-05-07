<template>
    <v-container
        v-if="!mobile"
    >
        <v-row
            justify="center"
        >
            <v-col
                v-for="content in contents"
                xs="7"
                sm="4"
            >
                <ContentCard
                    :content="content"
                />
            </v-col>
        </v-row>
    </v-container>
    <ContentCard
        v-if="mobile"
        v-for="content in contents"
        class="mt-2"
        :content="content"
    />
</template>

<script setup>
    import { useDisplay } from 'vuetify';

    const { mobile } = useDisplay();

    const { contents } = defineProps({
        contents: Array
    });
</script>