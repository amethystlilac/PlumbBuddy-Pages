<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Features', to: '/features'}, {title: 'Mod Health'}]"
    />
    <div class="main-container">
        <p>
            PlumbBuddy is <strong>always</strong> watching your game and Mods folder, on the look-out for anything to tell you about... <em>and help you with</em>.
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
            color: 'primary',
            icon: 'mdi-cog',
            name: 'Ensuring Optimal Game Options',
            image: 'switches.webp',
            description: `
If you have script and/or package mods installed, but they are disabled in The Sims 4, PlumbBuddy will tell you and offer to change the option setting for you.
            
And if that pesky **Show Mods List at Startup** "feature" of the game is enabled, PlumbBuddy will warn you about that and offer to turn it off for you, helping you recover valuable game start-up time.
`,
        },
        {
            color: 'secondary',
            icon: 'mdi-folder-wrench',
            name: 'Finding Problems in Your Mods Folder',
            image: 'messy_storage_room.jpeg',
            description: `
There are certain non-negotiable rules when it comes to installing mods in The Sims 4—regarding technicalities such as file-folder depth—and certain best practices on which the community universally agrees—e.g. don't put ZIP files in your Mods folder.
PlumbBuddy knows these rules and practices, and it watches your Mods folder with an eye toward them.
It will tell you when there's a change you ought to make—and in some cases, even offer to make it for you.

---

PlumbBuddy is also able to identify errors and exceptions logged by the game or by your mods.
If it finds any, it will guide you through the process of "taking your Sims 4 game to the doctor"—i.e. submitting the file to the Community Discord of your choice—if you want to know more about what went wrong.
`,
        },
        {
            color: 'tertiary',
            icon: 'mdi-package-variant-closed-plus',
            name: `Pointing Out Essentials You're Missing`,
            image: 'sunlight.jpg',
            description: `
PlumbBuddy's first priorities are safety and stability.
While **it is *categorically* not a mod manager**, it can and will make recommendations of mods to install.
There are two reasons it will do this.

---

###### General Game Safety and Stability
Examples in this category include [Deaderpool's MC Command Center](https://deaderpool-mccc.com/) and [TwistedMexi's ModGuard](https://www.patreon.com/posts/98126153).

---

###### *Your Game's* Stability *in Particular*
If the creator of a mod you've installed has specified that it requires a pack or another mod to work properly *and you don't have that installed*, PlumbBuddy will draw your attention to that fact and help you easily get that content into your game so the mod you've installed works as intended.
`,
        },
        {
            color: 'warning',
            icon: 'mdi-sync-alert',
            name: 'Performing Analysis of Your Game & Mods',
            image: 'scan_hologram.jpeg',
            description: `
Every time PlumbBuddy catalogs changes you've made in your Mods folder, you're going to briefly see: **Analyzing Topology**.

This means PlumbBuddy is considering how the mod packages you have installed are overriding each others' resources.
This is important because it tells PlumbBuddy whether a change that was just made has invalidated the game's cache, rendering it **stale**.
A stale cache can be the cause of strange glitches in the game's interface, so, accordingly, PlumbBuddy will alert you to the state of the cache—*and offer to clear it for you*.

---

Finally, some mods have complex installation requirements.
Using manifests, creators can instruct PlumbBuddy on all the intricate details of those requirements.
If they have done so, PlumbBuddy will double-check to ensure that their mod is installed in a correct manner.
If it is not, PlumbBuddy will report the problems it found to you—including links back to the creators' websites, if you need them—so that you can make informed decisions while fixing the problem.
`,
        },
    ];
</script>
