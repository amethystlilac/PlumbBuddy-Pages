<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Pack Selector'}]"
    />
    <v-container>
        <p>
            Want fast, simple, precise control over which Sims 4 packs are active when you launch the game?
        </p>
        <v-divider />
        <FeaturePanels
            :features="features"
        />
    </v-container>
</template>

<script setup>
    const features = [
        {
            color: 'primary',
            icon: 'mdi-toggle-switch',
            name: 'Choose What Loads',
            image: 'expansion_pack_tiles.jpg',
            description: `
Enable or disable packs before launching, tailoring the game to your current session.
No uninstalling, no hunting through files or writing tricky command line arguments manually—just a clean toggle that reconfigures your launcher for you.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-lightning-bolt',
            name: 'Speed and Focus',
            image: 'speed_and_accuracy.jpg',
            description: `
Cut down startup time and in-game clutter by loading only the packs you need.
Whether you’re playtesting, storytelling, or just trying to get into the game faster, Pack Selector trims the excess.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-link-variant',
            name: 'In Sync with Mod Health',
            image: 'mod_health_cooperation.jpg',
            description: `
PlumbBuddy knows which packs you’ve disabled.
If a mod depends on one you’ve turned off, [Mod Health](mod-health) will flag it and offer to open Pack Selector so you can adjust right away.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-alert',
            name: 'Stay Informed, Stay Safe',
            image: 'raf_firefighter.jpg',
            description: `
Disabling packs has consequences: items, Sims, or worlds tied to them will disappear from saves if you continue playing and re-save.
Pack Selector doesn’t hide this—it gives you a clear warning up front every time.
`,
        },
    ];
</script>
