<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Who Are We?'}]"
    />
    <v-container
        style="margin-bottom: 38vh;"
    >
        <v-row
            justify="center"
        >
            <v-col
                v-for="person in folks"
                cols="12"
                md="6"
                lg="4"
            >
                <PersonCard
                    :person="person"
                />
            </v-col>
        </v-row>
    </v-container>
</template>

<script setup>
    const folks = [
    {
            image: 'AmethystLilacOnSixam.png',
            imagePosition: 'top center',
            accent: '#9A4DFF',
            name: 'Amethyst Lilac',
            title: 'Mod Creator Consultant',
            message: `Hi! I'm Amethyst. I mostly play occult and historical saves, and end up making the mods and cc I need that don't exist yet. I like to help people with their game, mod, and tech issues as a hobby.`,
            buttons: [
                {
                    icon: 'mdi-patreon',
                    label: 'Patreon',
                    href: 'https://www.patreon.com/amethystlilac',
                    tip: 'You can find me on Patreon',
                },
            ],
        },
        {
            image: 'BlackCherry.png',
            accent: '#FFC83D',
            name: 'BlackCherry',
            title: 'Windows Support Consultant',
            message: `Hi, I'm BlackCherry! When I'm not busy with one of my legacy saves or taking a break from playing to build, I like to help people with their games.`,
            buttons: [
                {
                    icon: 'mdi-post',
                    label: 'Blog',
                    href: 'https://museurania462371994.wordpress.com/',
                    tip: 'Check out my Blog',
                },
            ],
        },
        {
            image: 'CodeBleuWithBuddy.png',
            imagePosition: 'top center',
            accent: '#00a2ff',
            name: 'CodeBleu',
            title: 'Developer',
            message: `I do all the coding (so far), as my name would suggest. They say behind every great man is a woman rolling her eyes, and fate saw fit to bless me with *a few to spare*. Take from that what you will.`,
            buttons: [
                {
                    icon: 'mdi-view-gallery',
                    label: 'itch.io',
                    href: 'https://codebleu.itch.io/',
                    tip: 'I have a profile on itch.io',
                },
            ],
        },
        {
            image: 'HelenTheHunter.png',
            imagePosition: 'top center',
            accent: '#FF8C00',
            name: 'Helen',
            title: 'User Experience Consultant',
            message: `Hi, I'm Helen the Hunter. I love to make mods and help people fix their modded game. When I actually get round to playing I like doing short(ish) challenges and giving SimMe all the things I can't afford in real life.`,
            buttons: [
                {
                    icon: 'mdi-patreon',
                    label: 'Patreon',
                    href: 'https://www.patreon.com/BrightOrangeSunset',
                    tip: 'You can find me on Patreon',
                },
            ],
        },
        {
            image: 'MegAtPark.png',
            imagePosition: 'top center',
            accent: '#74c044',
            name: 'Meg',
            title: 'macOS Support Consultant',
            message: `Hi I'm Meg! I'm a Mac simmer here to help out fellow simmers, especially my fellow Mac users 🙂. Otherwise you can find me playing in CAS or starting a new challenge.`,
            buttons: [
                {
                    icon: 'mdi-patreon',
                    label: 'Patreon',
                    href: 'https://www.patreon.com/meg_toastie_sim',
                    tip: 'You can find me on Patreon',
                },
            ],
        },
    ];
</script>
