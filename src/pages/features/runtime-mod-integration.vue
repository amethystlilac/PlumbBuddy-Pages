<template>
    <MenuToggleBreadcrumbs
        color="tertiary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Runtime Mod Integration'}]"
    />
    <v-container>
        <iframe src="https://www.youtube.com/embed/5lxPsoH8m50" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen style="width: 100%; aspect-ratio: 16/9;"></iframe>
    </v-container>
    <FeaturePanels
        :features="features"
    />
</template>

<script setup>
    const features = [
        {
            color: 'tertiary',
            icon: 'mdi-bridge',
            name: 'UI Bridge',
            image: 'holographic-hud.jpg',
            description: `
The UI Bridge allows script mods in The Sims 4 to present interactive user interfaces from within the PlumbBuddy desktop application.

These UIs are defined using standard web technologies (HTML, JavaScript, CSS) and are bundled within ${'`'}.ts4script${'`'} files.
When authorized by the player, PlumbBuddy renders the bridged UI in a native web view running in its own process that cannot access the internet, but can engage in two-way communication with the gateway, similarly to how script mods can.
`,
            buttonIcon: 'mdi-book-cog',
            buttonLabel: 'Technical Documentation',
            href: 'https://github.com/Llama-Logic/PlumbBuddy/wiki/UI-Bridge',
        },
        {
            color: 'tertiary',
            icon: 'mdi-database-import',
            name: 'Relational Data Storage',
            image: 'database.jpg',
            description: `
Relational Data Storage (RDS) provides script mods (and bridged UIs) with robust, persistent access to native relational databases, enabling them to store, query, and manage structured data using standard SQL.

This system is designed for mods that require more complex data handling than what is feasible with in-memory structures or ad hoc file persistence, without burdening creators with file management, save file manipulation, and most importantly slowing down the simulation.
`,
            buttonIcon: 'mdi-book-cog',
            buttonLabel: 'Technical Documentation',
            href: 'https://github.com/Llama-Logic/PlumbBuddy/wiki/Relational-Data-Storage',
        },
    ];
</script>