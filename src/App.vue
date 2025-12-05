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

    const mediaQuery = window.matchMedia('(prefers-color-scheme: dark)');

    const updateTheme = () => {
        const prefersDark = mediaQuery.matches;
        theme.change(prefersDark ? 'dark' : 'light');
    };

    onMounted(() => {
        updateTheme();
        mediaQuery.addEventListener('change', updateTheme);
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
        mediaQuery.removeEventListener('change', updateTheme);
    });
</script>
