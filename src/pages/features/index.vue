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
            name: 'Catalog',
            image: 'catalogs.jpeg',
            description: `Manifests aren't *just* for me and the Mod Creators. You get to see what they say, too! And that can be *quite useful*.`,
            to: 'features/catalog',
        },
        /*{
            color: 'primary',
            icon: 'mdi-dog',
            name: 'Mod Hound',
            image: 'Nose.png',
            description: 'As another way to help you keep your Mods folder healthy, ModHound has partnered with PlumbBuddy to let you get reports from inside the app. Find your broken and outdated mods at the click of a button!',
            to: 'features/mod-hound',
        },*/
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
    ];
</script>
