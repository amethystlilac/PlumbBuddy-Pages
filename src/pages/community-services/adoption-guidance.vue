<template>
    <MenuToggleBreadcrumbs
        color="tertiary"
        :items="[{title: 'Community Services', to: '/community-services'}, {title: 'Adoption Guidance'}]"
    />
    <div class="main-container">
        <Markdown :source="adoptionGuidancePart1Markdown" class="standard-text" />
        <div class="mx-auto" style="width: 560px;">
            <iframe width="560" height="315"
                    src="https://www.youtube.com/embed/6VAF1YThcbc"
                    title="YouTube video player"
                    frameborder="0"
                    allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
                    allowfullscreen>
            </iframe>
            <p class="text-center" style="font-size: .9rem;">
                <em>On the Creator Musings Discord server, you may get to meet the Lady MizoreYukii, just like Sir Ian McKellen did when he first adopted an orphaned Sims 4 mod!</em>
            </p>
        </div>
        <Markdown :source="adoptionGuidancePart2Markdown" class="standard-text" />
    </div>
</template>

<script setup>
    import Markdown from 'vue3-markdown-it';
    import adoptionGuidancePart1Markdown from './adoption-guidance-part-1.md?raw';
    import adoptionGuidancePart2Markdown from './adoption-guidance-part-2.md?raw';
</script>