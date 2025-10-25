<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Personal Notes & Catalog'}]"
    />
    <v-container>
        <p>
            Had to wait a while for all those mod files to get cataloged, eh?
            Well, it wasn't <em>just</em> for Mod Health.
            Want to see what <strong>you</strong> get out of it?
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
            icon: 'mdi-certificate',
            name: 'See a List of All Your Mods',
            image: 'catalog_listing.jpg',
            description: `
The **Personal Notes** tab allows you to quickly view every mod file you have installed.
It will also display the notes and dates significant to you which you have set for any of them.
You can click the icon on the left side of any entry to have that mod file shown to you in Windows Explorer or macOS Finder.

On the other hand, the **Catalog** tab displays a list of the manifested mods you have installed.
It does this on the basis of whole mods rather than individual files, though it will show you the files that are a part of a mod.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-details',
            name: 'Drill Down Into the Details',
            image: 'checklist.jpg',
            description: `
On the **Personal Notes** tab, selecting a mod file presents fields to edit your own notes or a date significant to you.
These notes and dates will be preserved regardless of moving mod files around or updating them.

Once you select a mod in the **Catalog**, it will show you basic details about the mod.
Included below these details will be the location in your Mods folder of each file that's a part of the mod, along with buttons that open Windows File Explorer or macOS Finder right to that file.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-graph',
            name: 'Discover How Your Mods Need Each Other',
            image: 'dependency_graph.png',
            description: `
The **Catalog** entry for every mod will list both its dependencies (the mods it requires) *and its dependents* (the mods which require it).
You are able to see names, creators, and even download page URLs for each related mod.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-magnify',
            name: 'Search All of the Things',
            image: 'magnifying_glass.png',
            description: `
Search and filter boxes in both the **Personal Notes** and **Catalog** tabs give you the power to look for anything.
The **Personal Notes** filters for dates operate on a range, and the mod files displayed are sortable.
`,
        },
    ];
</script>
