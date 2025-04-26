<template>
  <v-carousel
    cycle
    :height="`${carouselHeight}px`"
  >
    <v-carousel-item
      v-for="carouselItem in carouselItems"
      :src="carouselItem.background"
      cover
    >
      <div
        class="w-100 h-100 px-4 d-flex justify-center align-end"
      >
        <v-card
          class="mb-16 mx-16"
          :color="carouselItem.color"
          elevation="20"
          :title="carouselItem.title"
        >
          <v-card-text>
            <p v-html="carouselItem.text"></p>
          </v-card-text>
          <v-card-actions>
            <v-btn
              :prepend-icon="carouselItem.buttonIcon"
              :text="carouselItem.buttonText"
              @click="handleCarouselItemButtonClicked(carouselItem)"
            />
          </v-card-actions>
        </v-card>
      </div>
    </v-carousel-item>
  </v-carousel>
  <div
    v-if="currentRelease"
    class="ma-4 d-flex ga-4"
  >
    <v-alert
      density="compact"
      icon="mdi-application"
      variant="tonal"
    >
      <span v-if="!xs">Current version: </span>
      <strong>{{ currentVersion }}</strong>
    </v-alert>
    <v-alert
      :color="tagRoot === 'release-alpha' ? 'error' : tagRoot === 'release-beta' ? 'warning' : tagRoot === 'release-preview' ? 'info' : 'success'"
      density="compact"
      :icon="tagRoot === 'release-alpha' ? 'mdi-alpha' : tagRoot === 'release-beta' ? 'mdi-beta' : tagRoot === 'release-preview' ? 'mdi-certificate-outline' : 'mdi-certificate'"
      variant="tonal"
    >
      <span v-if="!xs">Lifecycle stage: </span>
      <strong>{{ tagRoot === 'release-alpha' ? 'Alpha' : tagRoot === 'release-beta' ? 'Beta' : tagRoot === 'release-preview' ? 'Preview' : 'Stable' }}</strong>
    </v-alert>
  </div>
</template>

<script setup>
  import { ref, computed, onMounted, onBeforeUnmount } from 'vue';
  import { useRouter } from 'vue-router';
  import { useDisplay } from 'vuetify';
  import { useAppStore } from '@/stores/app';

  const router = useRouter();
  const appStore = useAppStore();
  const currentRelease = ref(null);
  const tagRoot = ref('');
  const currentVersion = ref('');

  const height = ref(window.innerHeight);
  const { xs } = useDisplay();

  const updateHeight = () => {
    height.value = window.innerHeight;
  }

  onMounted(async () => {
    await appStore.loadReleases();
    currentRelease.value = appStore.currentRelease;
    const tagNameElements = currentRelease.value.tag_name.split('/');
    tagRoot.value = tagNameElements[0];
    currentVersion.value = tagNameElements[1];
    window.addEventListener('resize', updateHeight);
  });

  onBeforeUnmount(() => {
    window.removeEventListener('resize', updateHeight);
  });

  const carouselHeight = computed(() => height.value - 120);
  const carouselItems = [
    {
      background: '@/assets/boseong.jpg',
      color: 'success',
      title: 'PlumbBuddy 1.3 is Here!',
      text: `Your buddy to help with mods and saves now also helps you help other mod users if you understand multiple languages!`,
      buttonIcon: 'mdi-download',
      buttonText: 'Download Now!',
      buttonPath: '/download',
    },
    {
      background: '@/assets/mod_health_scans.jpg',
      color: 'primary',
      title: 'Mod Health',
      text: `Mod Health helps you by <strong>Ensuring Optimal Game Options</strong>, <strong>Finding Problems in Your Mods Folder</strong>, <strong>Pointing Out Essentials You're Missing</strong>, and <strong>Performing Analysis of Your Game &amp; Mods</strong>.`,
      buttonIcon: 'mdi-bottle-tonic-plus',
      buttonText: 'Learn More',
      buttonPath: '/features/mod-health',
    },
    {
      background: '@/assets/arcane_vault.jpg',
      color: 'secondary',
      title: 'Archivist',
      text: `Archivist is ready to help you never lose a save again.`,
      buttonIcon: 'mdi-archive-clock',
      buttonText: 'Learn More',
      buttonPath: '/features/archivist',
    },
    {
      background: '@/assets/santorini.jpg',
      color: 'secondary',
      title: 'Parlay',
      text: `Is there a mod that you love but it's just not available in your language? Parlay is there for you.`,
      buttonIcon: 'mdi-translate-variant',
      buttonText: 'Learn More',
      buttonPath: '/features/parlay',
    },
    {
      background: '@/assets/construction_workers.jpg',
      color: 'tertiary',
      title: 'Manifest Editor',
      text: `<em>Finally</em>, Creators can make mods self-describing: identifying <strong>who</strong> made them, <strong>where</strong> they came from, and <strong>what</strong> they need.`,
      buttonIcon: 'mdi-tag-edit',
      buttonText: 'Learn More',
      buttonPath: '/features/manifest-editor',
    },
  ];

  function handleCarouselItemButtonClicked(carouselItem) {
    if (carouselItem.buttonHref) {
      window.open(carouselItem.buttonHref, '_blank');
      return;
    }
    router.push(carouselItem.buttonPath);
  }
</script>