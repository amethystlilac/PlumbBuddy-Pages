<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Guides'}]"
    />
    <v-container>
        <SectionMenu
            :sections="sections"
        />
    </v-container>
</template>

<script setup>
    const sections = [
        {
            color: 'primary',
            icon: 'mdi-play-circle',
            name: 'Casual Player Setup',
            image: 'WomanWorkingLaptop.jpeg',
            description: `If you just want to install it and not worry too much about it, this is for you.`,
            to: 'text-guides/casual-setup',
        },     
    ];
</script>
