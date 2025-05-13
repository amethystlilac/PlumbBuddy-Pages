<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Parlay'}]"
    />
    <v-container>
        <v-divider />
        <div class="mx-auto" style="width: 560px;">
			<iframe width="560" height="315" src="https://www.youtube.com/embed/T60_aToD_nM" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
        </div>
        <p>
            <center>Parlay</center>
            <center>Your Mods in Your Language</center>
        </p>
        <Markdown
            :source="playerParlayMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import playerParlayMarkdown from './player-parlay.md?raw';
</script>