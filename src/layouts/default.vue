<template>
  <v-navigation-drawer
    v-model="drawer"
    :rail="rail && !appStore.isPhone"
    @click="rail = false"
  >
    <v-list-item
      prepend-avatar="/img/PlumbBuddyLogo.svg"
      title="PlumbBuddy"
    >
      <template v-slot:append>
        <v-btn
          icon="mdi-chevron-left"
          variant="text"
          @click.stop="rail = !rail"
        />
      </template>
    </v-list-item>
    <v-divider />
    <v-list
      density="compact"
      nav
    >
      <template
        v-for="navLocation in navLocations"
        :key="navLocation.path"
      >
        <v-list-item
          v-if="navLocation.path === '/'"
          :active="String(route.path) === navLocation.path"
          :color="navLocation.color"
          :prepend-icon="navLocation.icon"
          :title="navLocation.title"
          @click="navigate(navLocation)"
        />
        <v-divider
          v-else-if="navLocation.isDivider"
        />
        <v-list-item
          v-else-if="navLocation.subheaderTitle"
          disabled
          :prepend-icon="navLocation.icon"
          :title="navLocation.subheaderTitle"
          type="subheader"
        />
        <v-list-item
          v-else
          :active="String(route.path).startsWith(navLocation.path)"
          :color="navLocation.color"
          :prepend-icon="navLocation.icon"
          :title="navLocation.title"
          @click="navigate(navLocation)"
        />
      </template>
    </v-list>
  </v-navigation-drawer>

  <div id="site-background"></div>
  <v-main>
    <router-view />
  </v-main>

  <AppFooter @open-menu="drawer = true" />
</template>

<script setup>
  import { ref } from 'vue';
  import { useRouter, useRoute } from 'vue-router';
  import { useAppStore } from '@/stores/app';

  const router = useRouter();
  const route = useRoute();
  const appStore = useAppStore();

  const drawer = ref(!appStore.isPhone);
  const rail = ref(true);

  const navLocations = [
  {
      color: 'primary',
      icon: 'mdi-rocket-launch',
      path: '/',
      title: 'Landing',
    },
    {
      color: 'success',
      icon: 'mdi-download',
      path: '/download',
      title: 'Download',
    },
    {
      color: 'info',
      icon: ['M22,24L16.75,19L17.38,21H4.5A2.5,2.5 0 0,1 2,18.5V3.5A2.5,2.5 0 0,1 4.5,1H19.5A2.5,2.5 0 0,1 22,3.5V24M12,6.8C9.32,6.8 7.44,7.95 7.44,7.95C8.47,7.03 10.27,6.5 10.27,6.5L10.1,6.33C8.41,6.36 6.88,7.53 6.88,7.53C5.16,11.12 5.27,14.22 5.27,14.22C6.67,16.03 8.75,15.9 8.75,15.9L9.46,15C8.21,14.73 7.42,13.62 7.42,13.62C7.42,13.62 9.3,14.9 12,14.9C14.7,14.9 16.58,13.62 16.58,13.62C16.58,13.62 15.79,14.73 14.54,15L15.25,15.9C15.25,15.9 17.33,16.03 18.73,14.22C18.73,14.22 18.84,11.12 17.12,7.53C17.12,7.53 15.59,6.36 13.9,6.33L13.73,6.5C13.73,6.5 15.53,7.03 16.56,7.95C16.56,7.95 14.68,6.8 12,6.8M9.93,10.59C10.58,10.59 11.11,11.16 11.1,11.86C11.1,12.55 10.58,13.13 9.93,13.13C9.29,13.13 8.77,12.55 8.77,11.86C8.77,11.16 9.28,10.59 9.93,10.59M14.1,10.59C14.75,10.59 15.27,11.16 15.27,11.86C15.27,12.55 14.75,13.13 14.1,13.13C13.46,13.13 12.94,12.55 12.94,11.86C12.94,11.16 13.45,10.59 14.1,10.59Z'],
      path: '/join-our-discord',
      href: 'https://discord.gg/XKbMEEfRde',
      title: 'Join our Discord',
    },
    {
      color: 'info',
      icon: 'mdi-account-question',
      path: '/who-are-we',
      title: 'Who Are We?',
    },
    {
      isDivider: true,
    },
    {
      color: 'primary',
      icon: 'mdi-feature-search',
      path: '/features',
      title: 'Features',
    },
    {
      color: 'primary',
      icon: 'mdi-bottle-tonic-plus',
      path: '/features/mod-health',
      title: 'Mod Health',
    },
    {
      color: 'primary',
      icon: 'mdi-book',
      path: '/features/catalog',
      title: 'Catalog',
    },
    {
      color: 'secondary',
      icon: 'mdi-archive-clock',
      path: '/features/archivist',
      title: 'Archivist',
    },
    {
      color: 'secondary',
      icon: 'mdi-translate-variant',
      path: '/features/parlay',
      title: 'Parlay',
    },
    {
      color: 'tertiary',
      icon: 'mdi-tag-edit',
      path: '/features/manifest-editor',
      title: 'Manifest Editor',
    },
    {
      isDivider: true,
    },
    {
      color: 'secondary',
      icon: 'mdi-source-repository',
      path: '/source-code',
      href: 'https://github.com/orgs/Llama-Logic/repositories',
      title: 'Source Code',
    },
    {
      color: 'secondary',
      icon: 'mdi-application',
      path: '/source-code/pb',
      href: 'https://github.com/Llama-Logic/PlumbBuddy',
      title: 'PlumbBuddy',
    },
    {
      color: 'secondary',
      icon: 'mdi-package-variant',
      path: '/source-code/llp',
      href: 'https://github.com/Llama-Logic/LlamaLogic',
      title: 'Llama Logic Packages',
    },
    {
      color: 'secondary',
      icon: 'mdi-web-box',
      path: '/source-code/site',
      href: 'https://github.com/Llama-Logic/PlumbBuddy-Pages',
      title: 'This Web Site',
    },
    {
      isDivider: true,
    },
    {
      color: 'tertiary',
      icon: 'mdi-offer',
      path: '/community-services',
      title: 'Community Services',
    },
    {
      color: 'tertiary',
      icon: 'mdi-share',
      path: '/community-services/redirect-hosting',
      title: 'Redirect Hosting',
    },
    {
      color: 'tertiary',
      icon: 'mdi-face-agent',
      path: '/community-services/support-venues',
      title: 'Support Venues',
    },
    {
      isDivider: true,
    },
    {
      color: 'info',
      icon: 'mdi-file-sign',
      path: '/terms-of-use',
      title: 'Terms of Use',
    },
    {
      color: 'info',
      icon: 'mdi-shield-account',
      path: '/privacy-policy',
      title: 'Privacy Policy',
    },
  ];

  function navigate(navLocation) {
    if (navLocation.href) {
      window.open(navLocation.href, '_blank');
      return;
    }
    router.push(navLocation.path);
  }
</script>

<style>
  #site-background {
    background-image: url(/img/Cloudy.svg);
    background-position: center;
    background-size: cover;
    height: 100vh;
    left: 0;
    opacity: .15;
    overflow: hidden;
    pointer-events: none;
    position: fixed;
    top: 0;
    width: 100vw;
  }
</style>