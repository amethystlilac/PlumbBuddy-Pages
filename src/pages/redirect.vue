<template>
    <MenuToggleBreadcrumbs
        color="info"
        :items="[{title: 'Redirect'}]"
    />
    <div class="main-container">
        <v-alert
            v-if="status === 'noRedirect'"
            text="This page is for launching redirects and no redirect has been specified. I have nothing to do."
        />
        <v-alert
            v-if="status === 'tooManyRedirects'"
            text="This page is for launching redirects and too many redirects have been specified. I can't send you to multiple places at once."
            type="warning"
        />
        <v-alert
            v-if="status === 'loadingRedirects'"
            text="Just a moment while I look up where to redirect you..."
            type="info"
        />
        <v-progress-linear
            v-if="status === 'loadingRedirects'"
            class="mt-4"
            color="info"
            height="12"
            indeterminate
        />
        <v-alert
            v-if="status === 'loadingRedirectsFailed'"
            text="I failed to properly load my catalog of redirects. You may want to get in touch with someone about this."
            type="error"
        />
        <Display404
            v-if="status === 'redirectNotFound'"
        />
        <v-alert
            v-if="status === 'redirecting'"
            text="You are being redirected to your intended destination now."
            type="success"
        />
        <v-progress-linear
            v-if="status === 'redirecting'"
            class="mt-4"
            color="success"
            height="12"
            indeterminate
        />
        <p
            v-if="status === 'redirecting'"
        >
            Or, just click here: <a :href="url">{{ url }}</a>
        </p>
    </div>
</template>

<script setup>
    import sleep from 'sleep-promise';
    import { ref, onMounted } from 'vue';
    import { useRoute } from 'vue-router';
    import YAML from 'yaml';

    const route = useRoute();

    const status = ref('');
    const url = ref('');

    onMounted(async () => {
        if (!route.query.to && !route.query['purchase-pack']) {
            status.value = 'noRedirect';
            return;
        }
        if (Array.isArray(route.query.to) || Array.isArray(route.query['purchase-pack'])) {
            status.value = 'tooManyRedirects';
            return;
        }
        status.value = 'loadingRedirects';
        try {
            if (route.query['purchase-pack']) {
                const pack = YAML.parse(await (await fetch('/community-data/packs.yml')).text())[route.query['purchase-pack']];
                if (!pack) {
                    status.value = 'redirectNotFound';
                    return;
                }
                url.value = route.query.from === 'steam' ? `https://store.steampowered.com/app/${pack.steam_stub}` : `https://www.ea.com/games/the-sims/the-sims-4/store/addons/${pack.ea_stub}`;
            } else {
                const redirect = YAML.parse(await (await fetch('/community-data/redirects.yml')).text())[route.query.to];
                if (!redirect) {
                    status.value = 'redirectNotFound';
                    return;
                }
                url.value = redirect;
            }
            status.value = 'redirecting';
            await sleep(3000);
            window.location.href = url.value;

        } catch (err) {
            console.error(err);
            status.value = 'loadingRedirectsFailed';
            return;
        }
    });
</script>