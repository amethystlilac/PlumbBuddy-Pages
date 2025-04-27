<template>
  <v-footer
    app
    height="40"
  >
    <router-link
      title="Landing"
      to="/"
    >
      <v-avatar
        image="/img/PlumbBuddyLogo.svg"
        size="24"
      />
      <v-tooltip
        activator="parent"
        location="top"
      >
        Landing
      </v-tooltip>
    </router-link>
    <v-divider
      class="ml-3"
      vertical
    />
    <router-link
      v-for="navLocation in navLocations"
      :title="navLocation.title"
      :to="navLocation.path"
    >
      <v-icon
        class="ml-3"
        :color="navLocation.color"
        :icon="navLocation.icon"
        size="20"
      >
      </v-icon>
      <v-tooltip
        activator="parent"
        location="top"
      >
        {{ navLocation.title }}
      </v-tooltip>
    </router-link>
    <v-divider
      class="ml-3"
      vertical
    />
    <a
      v-for="item in items"
      :key="item.title"
      class="d-inline-block mx-2 social-link"
      :href="item.href"
      rel="noopener noreferrer"
      target="_blank"
      :title="item.title"
    >
      <v-icon
        :icon="item.icon"
        :size="item.icon === '$vuetify' ? 24 : 16"
      />
      <v-tooltip
        activator="parent"
        location="top"
      >
        {{ item.title }}
      </v-tooltip>
    </a>

    <div
      class="text-caption text-disabled"
      style="position: absolute; right: 16px;"
    >
      <span class="d-none d-sm-inline-block">This site is neither affiliated with nor endorsed by Maxis or Electronic Arts, Inc.</span>
    </div>
  </v-footer>
</template>

<script setup>
  import { useAppStore } from '@/stores/app';

  const appStore = useAppStore();

  const navLocations = [
    {
      color: 'success',
      icon: 'mdi-download',
      path: '/download',
      title: 'Download',
    },
    {
      color: 'info',
      icon: 'mdi-account-question',
      path: '/who-are-we',
      title: 'Who Are We?',
    },
    {
      color: 'primary',
      icon: 'mdi-feature-search',
      path: '/features',
      title: 'Features',
    },
    {
      color: 'tertiary',
      icon: 'mdi-offer',
      path: '/community-services',
      title: 'Community Services',
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

  const items = [
    {
      title: 'LlamaLogic GitHub',
      icon: `mdi-github`,
      href: 'https://github.com/Llama-Logic',
    },
    {
      title: 'PlumbBuddy Discord',
      icon: ['M22,24L16.75,19L17.38,21H4.5A2.5,2.5 0 0,1 2,18.5V3.5A2.5,2.5 0 0,1 4.5,1H19.5A2.5,2.5 0 0,1 22,3.5V24M12,6.8C9.32,6.8 7.44,7.95 7.44,7.95C8.47,7.03 10.27,6.5 10.27,6.5L10.1,6.33C8.41,6.36 6.88,7.53 6.88,7.53C5.16,11.12 5.27,14.22 5.27,14.22C6.67,16.03 8.75,15.9 8.75,15.9L9.46,15C8.21,14.73 7.42,13.62 7.42,13.62C7.42,13.62 9.3,14.9 12,14.9C14.7,14.9 16.58,13.62 16.58,13.62C16.58,13.62 15.79,14.73 14.54,15L15.25,15.9C15.25,15.9 17.33,16.03 18.73,14.22C18.73,14.22 18.84,11.12 17.12,7.53C17.12,7.53 15.59,6.36 13.9,6.33L13.73,6.5C13.73,6.5 15.53,7.03 16.56,7.95C16.56,7.95 14.68,6.8 12,6.8M9.93,10.59C10.58,10.59 11.11,11.16 11.1,11.86C11.1,12.55 10.58,13.13 9.93,13.13C9.29,13.13 8.77,12.55 8.77,11.86C8.77,11.16 9.28,10.59 9.93,10.59M14.1,10.59C14.75,10.59 15.27,11.16 15.27,11.86C15.27,12.55 14.75,13.13 14.1,13.13C13.46,13.13 12.94,12.55 12.94,11.86C12.94,11.16 13.45,10.59 14.1,10.59Z'],
      href: 'https://discord.gg/XKbMEEfRde',
    },
    {
      title: 'EA Custom Content Policy',
      icon: [
        'M16.627,6.164l-5.911,9.343h-6.478l1.493-2.298h4.03l1.463-2.328H2.239l-1.463,2.328h2.149L0,17.836h12.06l4.567-7.283,1.672,2.656h-1.433l-1.462,2.298h4.358l1.463,2.328h2.776l-7.373-11.671',
        'M14.687,6.254H5.164l-1.463,2.328,9.522-.03,1.463-2.299'
      ],
      href: 'https://help.ea.com/en-gb/help/the-sims/the-sims-4/mods-and-the-sims-4-game-updates/',
    },
    {
      title: 'Play The Sims 4 for Free!',
      icon: ['M6.852,11.073L14.056.585l3.093,12.342-7.204,10.487-3.093-12.342ZM9.909,11.624L14.063.546l.028,11.83-4.153,11.077-.028-11.83ZM6.922,11.086l10.173,1.832'],
      href: 'https://www.ea.com/games/the-sims/the-sims-4/download',
    },
  ]
</script>

<style scoped lang="sass">
  .social-link :deep(.v-icon)
    color: rgba(var(--v-theme-on-background), var(--v-disabled-opacity))
    text-decoration: none
    transition: .2s ease-in-out

    &:hover
      color: rgba(25, 118, 210, 1)
</style>
