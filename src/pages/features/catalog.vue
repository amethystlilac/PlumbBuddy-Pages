<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Catalog'}]"
    />
    <v-container>
        <p>
            Just a moment...
        </p>
    </v-container>
</template>

<script setup>
    import { useRouter } from 'vuetify/lib/composables/router.mjs';
    const router = useRouter();
    router.push('/features/personal-notes-and-catalog')
</script>
