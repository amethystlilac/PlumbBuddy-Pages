<template>
    <v-breadcrumbs
        :bg-color="color"
        :items="[{title: 'PlumbBuddy.app', to: '/'}, ...(items ?? [])]"
    >
        <template
            v-slot:prepend
        >
            <v-img
                class="mr-2"
                height="24"
                src="/img/PlumbBuddyLogo.svg"
                width="24"
                @click="toggleMenu"
            />
        </template>
    </v-breadcrumbs>
</template>

<script setup>
    import { useAppStore } from '@/stores/app';

    const appStore = useAppStore();

    const { color, items } = defineProps({
        color: String,
        items: Array
    });

    function toggleMenu() {
        appStore.setIsMenuOpen(!appStore.isMenuOpen);
    }
</script>