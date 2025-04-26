<template>
  <v-app>
    <router-view />
  </v-app>
</template>

<script setup>
  import { onMounted, onUnmounted } from 'vue';
  import { useRouter } from 'vue-router';
  import { useTheme } from 'vuetify';

  const router = useRouter();
  const theme = useTheme();

  const updateTheme = () => {
    const prefersDark = window.matchMedia('(prefers-color-scheme: dark)').matches;
    theme.global.name.value = prefersDark ? 'dark' : 'light';
  };

  onMounted(() => {
    updateTheme();
    window.matchMedia('(prefers-color-scheme: dark)').addEventListener('change', updateTheme);
    document.body.addEventListener('click', e => {
      let target = e.target;
      if (!(target instanceof HTMLAnchorElement)) {
        target = target?.closest('a');
      }
      if (target instanceof HTMLAnchorElement && !e.defaultPrevented && e.button === 0 && !target.target) {
        const href = target.getAttribute('href');
        const url = new URL(href, window.location.href);
        if (url.origin === window.location.origin && !/^[a-zA-Z][a-zA-Z\d+\-.]*:/.test(href)) {
          e.preventDefault();
          router.push(href);
        }
      }
    });
  });

  onUnmounted(() => {
    window.matchMedia('(prefers-color-scheme: dark)').removeEventListener('change', updateTheme);
  });
</script>
