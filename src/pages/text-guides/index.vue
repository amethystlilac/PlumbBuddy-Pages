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
        {
            color: 'primary',
            icon: 'mdi-clipboard-play',
            name: 'Enthusiast Player Setup',
            image: 'ManPlayingGameOnPersonalComputer.jpeg',
            description: `If you're someone who wants all the details, we've got you.`,
            to: 'text-guides/enthusiast-setup',
        },
        {
            color: 'secondary',
            icon: 'mdi-translate-variant',
            name: 'Parlay for Translators',
            image: 'santorini.jpg',
            description: `If you want to help other people have your favourite mod in your language or just have it for yourself, this guide get you started.`,
            to: 'text-guides/player-parlay',
        },/*
        {
            color: 'success',
            icon: 'mdi-play-box-multiple',
            name: 'Creator Setup',
            image: 'AppleComputerComputerKeyboard.jpeg',
            description: `A guide for creators getting to know PlumbBuddy for the first time.`,
            to: 'text-guides/creators-setup',
        },
        {
            color: 'success',
            icon: 'mdi-tag-edit',
            name: 'Manifest Editor for Creators',
            image: 'developer-discuss-photo-md.jpeg',
            description: `An in-depth guide to what you need to know to get your mods manifested.`,
            to: 'text-guides/creators-manifest-editor',
        },*/
        {
            color: 'error',
            icon: 'mdi-chat-question',
            name: 'Help with PlumbBuddy',
            image: 'Confused.jpeg',
            description: `If you still can't figure it out.`,
            to: 'text-guides/help',
        },  
    ];
</script>
