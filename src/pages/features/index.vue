<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features'}]"
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
            icon: 'mdi-bottle-tonic-plus',
            name: 'Mod Health',
            image: 'mod_health_scans.jpg',
            description: `PlumbBuddy is **always** watching your game and Mods folder, on the look-out for anything to tell you about... *and help you with*.`,
            to: 'features/mod-health',
        },
        {
            color: 'primary',
            icon: 'mdi-book',
            name: 'Personal Notes & Catalog',
            image: 'catalogs.jpeg',
            description: `Had to wait a while for all those mod files to get cataloged, eh? Well, it wasn't _just_ for Mod Health. Want to see what **you** get out of it?`,
            to: 'features/personal-notes-and-catalog',
        },
        {
            color: 'primary',
            icon: 'mdi-dog',
            name: 'Mod Hound',
            image: 'Nose.png',
            description: 'As another way to help you keep your Mods folder healthy, ModHound has partnered with PlumbBuddy to let you get reports from inside the app. Find your broken and outdated mods at the click of a button!',
            to: 'features/mod-hound',
        },
        {
            color: 'primary',
            icon: 'mdi-bag-personal-tag',
            name: 'Pack Selector',
            image: 'expansion_pack_tiles.jpg',
            description: 'Want fast, simple, precise control over which Sims 4 packs are active when you launch the game?',
            to: 'features/pack-selector',
        },
        {
            color: 'secondary',
            icon: 'mdi-archive-clock',
            name: 'Archivist',
            image: 'archivist_cloaked.jpg',
            description: `Archivist is ready to help you never lose a save again.`,
            to: 'features/archivist',
        },
        {
            color: 'secondary',
            icon: 'mdi-translate-variant',
            name: 'Parlay',
            image: 'santorini.jpg',
            description: `Is there a mod that you love but it's just not available in your language? Parlay is there for you.`,
            to: 'features/parlay',
        },
        {
            color: 'tertiary',
            icon: 'mdi-tag-edit',
            name: 'Manifest Editor',
            image: 'construction_workers.jpg',
            description: `*Finally*, Creators can make mods self-describing: identifying **who** made them, **where** they came from, and **what** they need.`,
            to: 'features/manifest-editor',
        },
        {
            color: 'tertiary',
            icon: 'mdi-access-point-network',
            name: 'Runtime Mod Integration',
            image: 'rmi.jpg',
            description: `Runtime Mod Integration adds and maintains special mod files to the player's Mods folder which allow your mods to interoperate with PlumbBuddy.`,
            to: 'features/runtime-mod-integration',
        },
    ];
</script>
