<template>
    <v-breadcrumbs
        bg-color="secondary"
        :items="[{title: 'PlumbBuddy.app', to: '/'}, {title: 'Features', to: '/features'}, {title: 'Archivist'}]"
    />
    <div class="main-container">
        <p>
            Archivist is ready to help you never lose a save again.
        </p>
        <v-divider />
        <FeaturePanels
            :features="features"
        />
    </div>
</template>

<script setup>
    const features = [
        {
            color: 'secondary',
            icon: 'mdi-content-save-edit',
            name: 'Automatic Archiving',
            image: 'arcane_vault.jpg',
            description: `
Archivist will take Snapshots each time you (or a mod like MCCC) saves the game, and will store it for you.
It will also scan any saves that already exist in your saves folder and make Snapshots of them too.
Then they'll be displayed in a searchable catalogue in PlumbBuddy, organized by Chronicle (the entire history of the save).

Archivist tags your Snapshots with the world name, lot name, and household name, and if the game was running when it archived the Snapshot, it will be tagged Live.
You can rename Snapshots or the entire Chronicle, and you can add notes.
And it's all searchable, including the date.

Live Snapshots have an extra special feature: they have a list of all of the mods that were in your mods folder when it was archived.
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-timer-sand',
            name: 'Restore and Branch',
            image: 'trees.jpg',
            description: `
Ever want to go back in time? Visit an old household and see where you could have taken them?
Decide that everything went wrong and you want to go in another direction completely?
And then find that your save has been lost because of the game's file culling systems?

Since Archivist saves your Snapshots, you have new options.
Once you use Archivist's search feature to find that perfect Snapshot, you can bring it (and your sims) back to life.

You can Restore, and bring that older Snapshot to the top of your saves list so that you can load into it right away.
This Snapshot will be identical to the original Snapshot, and any future saves will go into the original Chronical.

Or you can Branch.
This will create a brand new Chronicle within Archivist and a new slot in game.
Archivist will remember where it came from, but will treat it as if it was a new save, with its own new history.
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-home-heart',
            name: 'Restore and Branch',
            image: 'photos_in_photos.jpg',
            description: `
Pick a name and a thumbnail for your save's Chronicle within Archivist, and if you want, in the game too!
Archivist can rename your saves as you save them and give them your thumbnail so that you'll always know which save is which.
You can import a picture you have on your computer or pick a thumbnail from any of your Snapshots. ***And*** it can go back in time and assign your name and thumbnail to all the saves from the same Chronicle in your saves folder—but only if you tell it to, of course.
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-image-size-select-small',
            name: 'Little Storage Space',
            image: 'seashell.jpg',
            description: `
Your save files can take up a tonne of storage space in their original form.
Archivist uses compression to minimize the space its Chronicle files use, so that you have more space on your computer—or wherever you decide to store your archive.
The more Snapshots are in a Chronicle, the bigger the difference in total file size you'll see.
`,
        },
    ];
</script>
