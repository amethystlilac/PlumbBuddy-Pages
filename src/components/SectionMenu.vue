<template>
    <v-container>
        <v-row
            justify="center"
        >
            <v-col
                v-for="section in sections"
                cols="12"
                md="6"
                lg="4"
            >
                <SectionCard
                    :section="section"
                />
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    const { sections } = defineProps({
        sections: Array
    });
</script>