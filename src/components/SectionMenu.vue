<template>
    <v-container
        v-if="!mobile"
    >
        <v-row
            justify="center"
        >
            <v-col
                v-for="section in sections"
                xs="12"
                md="6"
                lg="4"
            >
                <SectionCard
                    :section="section"
                />
            </v-col>
        </v-row>
    </v-container>
    <SectionCard
        v-if="mobile"
        v-for="section in sections"
        class="mt-2"
        :section="section"
    />
</template>

<script setup>
    import { useDisplay } from 'vuetify';

    const { mobile } = useDisplay();

    const { sections } = defineProps({
        sections: Array
    });
</script>