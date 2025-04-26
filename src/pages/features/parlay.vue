<template>
    <v-breadcrumbs
        bg-color="secondary"
        :items="[{title: 'PlumbBuddy.app', to: '/'}, {title: 'Features', to: '/features'}, {title: 'Parlay'}]"
    />
    <div class="main-container">
        <div class="mx-auto" style="width: 560px;">
			<iframe width="560" height="315" src="https://www.youtube.com/embed/T60_aToD_nM?si=EB9Zh3d7VOFGiVqQ" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
        </div>
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
            icon: 'mdi-handshake',
            name: 'Any Mod, Available in Your Language',
            description: `
Is there a mod that you love but it's just not available in your language? Parlay is there for you.
It can help you translate it into your language, for your personal use, to share with everyone, or for the mod creator to include in the mod.

If you can understand any language the mod is already in, you can translate it to any other language you can write in.
Even ones that the game doesn't come in!
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-play-speed',
            name: 'Easy, Fast, Straightforward',
            description: `
Pick any package file that has text you can see in game.
Pick a language it's already in.
Enter your name.
Pick the language you want to translate to.
Start typing.

That's pretty much it.
Parlay will create the translation file for you, right in your mods folder.
All you need to do is put things in your own words.
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-account-heart',
            name: `Credit for the Work You've Done`,
            description: `
When someone uses your translation, your name will tell everyone that you were the one that let them enjoy the mod in a way they can understand.
Even if it's only for yourself, you can look at it with pride.
You did the work, you've earned it!
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-gesture-tap-button',
            name: 'Easy Integration by Modders',
            description: `
A new button in [Manifest Editor](/features/manifest-editor) makes it extremely easy for a modder to integrate any translation into their mod.
Click the button, find the file, say yes, and you're done.
If the translation was made in Parlay, it even credits the translator for you.

And a new field to let translators know how you want them to let you know about translations.
You can send them a message and give them a link they can follow to send it to you!
`,
        },
    ];
</script>
