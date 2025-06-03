<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Catalog'}]"
    />
    <v-container>
        <p>
            Manifests aren't <em>just</em> for me and the Mod Creators. You get to see what they say, too! And that can be <em>quite useful</em>.
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
            name: 'See a List of All Your Manifested Mods',
            image: 'catalog_listing.jpg',
            description: `
The Catalog prominently features a notice that only mods in which creators have included manifests will appear.

> Mods appear in your Catalog when creators have included manifests in them.

But for those which *are manifested*, you get to see a nice and tidy list.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-details',
            name: 'Drill Down Into the Details',
            image: 'checklist.jpg',
            description: `
Once you have selected a mod from the list, the Catalog will show you basic details about the mod.

Included below these details will be the location in your Mods folder of each file that's a part of the mod, along with buttons that open Windows File Explorer or macOS Finder right to that file.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-graph',
            name: 'Discover How Your Mods Need Each Other',
            image: 'dependency_graph.png',
            description: `
The Catalog entry for every mod will list both its dependencies (the mods it requires) *and its dependents* (the mods which require it).
You are able to see names, creators, and even download page URLs for each related mod.
`,
        },
        {
            color: 'primary',
            icon: 'mdi-magnify',
            name: 'Search All of the Things',
            image: 'magnifying_glass.png',
            description: `
Multiple search boxes in the Catalog's interface let you search for anything.
You can look for: a mod's name, one of its creators, its download page URL, its pack requirements, its dependencies, or its dependents.
`,
        },
    ];
</script>
