<template>
    <v-breadcrumbs
        bg-color="tertiary"
        :items="[{title: 'PlumbBuddy.app', to: '/'}, {title: 'Features', to: '/features'}, {title: 'Manifest Editor'}]"
    />
    <div class="main-container">
        <p>
            <em>Finally</em>, Creators can make mods self-describing: identifying <strong>who</strong> made them, <strong>where</strong> they came from, and <strong>what</strong> they need.
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
            color: 'tertiary',
            icon: 'mdi-file-check',
            name: 'Packages and Script Archives, However Many',
            image: 'gears.webp',
            description: `
The **Components** step in the Manifest Editor allows you to add as many package and script archive files that you need to, and even shows you the folder structure they have on your computer.

Each file can be marked by you as required by your mod or optional for the player.
When a file is required, you can even add caveats relating to packs or other mods.
PlumbBuddy can be instructed to ignore a requirement just because the player has or doesn't have some other content.

And, *trust us*, it's always aware of what the player has.
It will even tell them about requirements they've suddenly gained *just because* they installed something new today, even though they installed your mod months ago.

---

###### Package Manifests
These take the form of proper Snippet Tuning resources.
This means PlumbBuddy will let you set the name of the tuning if you want.
If you don't care, it will generate a random name for you.

Why not just use a proprietary or binary format?
Well, first of all, that wouldn't be very nice to script mod creators who might want to look at manifests, too!
And secondly, tools that merge packages generally have *no idea* about manifests.
We know some of you guys like to do that as a convenience for players, so to handle that use case without any errors, we chose to make them tuning so they don't clobber each other.
`,
        },
        {
            color: 'tertiary',
            icon: 'mdi-order-bool-descending-variant',
            name: 'Requirement Identifiers & Exclusivities',
            image: 'building_inspector.png',
            description: `
They both are ways that PlumbBuddy can think of mod files as part of a group, but they work differently and do different things.

---

###### Requirement Identifiers
These only apply to your mod's files.
If two or more files in your mod have the same requirement identifier, then only one of them is required.
You can use this to make sure the player has installed at least one of them.

PlumbBuddy won't care if the player has installed more than one of them.
That is, *unless*...

---

###### Exclusivities
These apply to the entire player's Mods folder, which means you can coordinate with other creators to use the same one if you want.
If two or more files in the player's Mods folder have the same exclusivity, PlumbBuddy is gonna get on the player's case.
You can use this to ensure the player has only picked one file from a set of options, or, in cooperation with another creator, make sure only one of your mods is installed.
Mod files can also have multiple exclusivities if you've been particularly busy.

---

Mod files can have both requirement identifiers and exclusivities.
But, unless you're [a.deep.indigo](https://www.patreon.com/adeepindigo) or [vyxated](https://www.patreon.com/vyxated) (cough), you probably won't ever need to do anything that complex.
But PlumbBuddy stands ready if you do!
`,
        },
        {
            color: 'tertiary',
            icon: 'mdi-asterisk',
            name: 'Some Things are Just Deal-Breakers',
            image: 'you_must_be_this_tall.jpg',
            description: `
The **Requirements** step deals with not just one of your mod's files, but the whole mod.
You can require that the player has (or doesn't have) certain packs.
Don't worry if you can't remember all the pack codes and don't want to look them up; there's a convenient switch to make all the pack code fields in the editor fun, searchable drop-down lists.
You can also require that the player has a certain mod installed, and if it's a mod that declares its features, even specify the features your mod needs.

---

###### EA Promo Codes
Can you believe your manifest could have your [EA Promo Code](https://creatornetwork.ea.com/) in it?
Well, it could, if you have one.
The reason why is because if PlumbBuddy finds that a player is missing a pack, it will direct them to EA for the collection of corporate blood money.
But before it does, it will show your code to the player and offer to copy it to their clipboard so they can easily paste it in at checkout.
It will even pat them on the pack for supporting creators. 💖
`,
        },
        {
            color: 'tertiary',
            icon: 'mdi-offer',
            name: 'Shining in the Support Role',
            image: 'helping_hand.webp',
            description: `
Not every mod does things on its own which players *actually see*.
But this category of mods includes **some of the most important ones**.
If your mod is there to make things easier for other mods, good on ya.
Tell PlumbBuddy all the details like your mod's version and name the features it offers.

---

###### Versions
It is odd (and perhaps charming) that some of you use silly things like the names of Beatles Albums for your mod versions.
We'll be cool with it.

If, however, you're using semantic version numbers, PlumbBuddy makes managing them a piece of cake.
It features links that describe the kinds of things which would cause the version number to change.
These links will adjust the version number accordingly for you.

---

###### Features
They're certainly not required, so if they feel like too much work, it's okay not to bother.
But if you do add them, then PlumbBuddy will show your feature list to other creators when they add your mod as a requirement.
When your mod is running on a player's computer, PlumbBuddy will double-check to make sure that the required mod still offers those features.
`,
        },
        {
            color: 'tertiary',
            icon: 'mdi-barcode-scan',
            name: 'The Magic of Hashing',
            image: 'magic_book.webp',
            description: `
So, mods may or may not have versions in their manifests... players are constantly renaming files all the time... *how does PlumbBuddy know whether things are okay?*
The answer is that inside each manifest is a crazy long number that was computed using the things in that mod file.

> This is why **it is very important** to update your manifests each time right before you publish an update to your mod.

---

###### Subsumption
When your mod's manifest is updated, the hash for the old version is added to its "subsumption list".
This is so that if another mod references your mod, it doesn't need to be updated just because you update your mod!
PlumbBuddy will know that the very latest version of your mod, for all intents and purposes, stands in for the older version.

---

###### Hashing Level
By default, we consider everything in a script archive and everything in a package file except its string tables and images.
We made that choice so that enterprising players trying to better suit your mod to their language won't break anything.
But, we let you decide your own hashing level.
`,
        },
        {
            color: 'tertiary',
            icon: 'mdi-vector-square-plus',
            name: `Scaffolding to Keep Your Mod's Files Together`,
            image: 'scaffolding.jpeg',
            description: `
The first time you write a manifest into your mod, PlumbBuddy will save a scaffolding file for each file in your mod.
This file is PlumbBuddy writing notes to itself, such as:
* The name of your mod
* Whether you marked that file as required
* What the component name of that file was
* What your hashing level was when you last updated the manifest
* How to find other files in your mod on your computer

Scaffolding files are YAML and fully commented, so if you're curious open them up and have a look.

> Since scaffolding files are there to help you update your mods quickly and easily, it would be best if you took care of them just like your own mod files.
> Keep them where they were written and back them up along with everything else.
> It's not game over if you lose them, but it will be a little annoying having to re-add all your mod files again later.

> Scaffolding files include information specific to your computer.
> You are **strongly advised** not to deploy them to players along with the rest of your mod's files.
> They won't be doing the players any good and might expose elements of the structure of your computer's file system.
> I don't know all of you personally, but *I can imagine* how some of you *could* be embarassed.
`,
        },
    ];
</script>
