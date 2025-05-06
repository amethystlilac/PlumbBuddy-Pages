<template>
    <MenuToggleBreadcrumbs
        color="primary"
        :items="[{title: 'Casual Player PlumbBuddy Setup Guide'}]"
    />
    <div class="main-container">
        <div class="mx-auto" style="width: 560px;">
			<iframe width="560" height="315" src="https://www.youtube.com/embed/5qze0OZn1Rw?si=EB9Zh3d7VOFGiVqQ" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
        </div>
        <p>
            <center>How to get PlumbBuddy up and running so you can get back to playing your game with something watching out for you.</center>
        </p>
        <v-divider />
        <ContentMenu
            :contents="contents"
        />
    </div>
</template>

<script setup>
    const contents = [
        {
            color: 'primary',
            icon: 'mdi-download-circle',
            name: 'Downloading PlumbBuddy',
            image: 'DownloadArrowGreen.jpeg',
            description: `How to download and install PlumbBuddy.`,
            to: 'casual-download',
        },
        {
            color: 'secondary',
            icon: 'mdi-clipboard-play',
            name: 'Starting PlumbBuddy for the First Time',
            image: 'ToggleGreen.png',
            description: `How to get it all up and running.`,
            to: 'casual-onboarding',
        },
        {
            color: 'success',
            icon: 'mdi-menu',
            name: 'User Interface Overview',
            image: 'checklist.png',
            description: `What are you looking at?`,
            to: 'casual-ui',
        },
        {
            color: 'info',
            icon: 'mdi-lifebuoy',
            name: 'Mod Health',
            image: 'helping-hand.jpeg',
            description: `What can PlumbBuddy do for you?`,
            to: 'casual-tabs',
        },
        {
            color: 'success',
            icon: 'mdi-radar',
            name: 'Mod Health Scans',
            image: 'nurse-health.jpeg',
            description: `What the Scans Tell You`,
            to: 'scans',
        },
    ];
</script>
