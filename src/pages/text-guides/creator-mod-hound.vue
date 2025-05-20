<template>
    <MenuToggleBreadcrumbs
        color="success"
        :items="[{title: 'Guides', to: '/text-guides'}, {title: 'Mod Hound'}]"
    />
    <v-container>
        <v-divider />
        <div class="mx-auto" style="width: 560px;">
			<iframe width="560" height="315" src="https://www.youtube.com/embed/-cB-HVPN45I" title="YouTube video player" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share" referrerpolicy="strict-origin-when-cross-origin" allowfullscreen></iframe>
        </div>
        <p>
            <center>Mod Hound</center>
            <center>A Different Way to Check Your Mods and Have Players Check <i>Their</i> Mods</center>
        </p>
        <Markdown
            :source="creatorModHoundMarkdown" 
            class="standard-text"
        />
    </v-container>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import creatorModHoundMarkdown from './creator-mod-hound.md?raw';
</script>