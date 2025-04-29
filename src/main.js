/**
 * main.js
 *
 * Bootstraps Vuetify and other plugins then mounts the App`
 */

// Plugins
import { registerPlugins } from '@/plugins';

// Components
import App from './App.vue';

// Composables
import { createApp } from 'vue';
import Markdown from 'vue3-markdown-it';
import 'highlight.js/styles/monokai.css';
import '@/styles/site.scss';

// Stores
import { useAppStore } from '@/stores/app';

const app = createApp(App);
app.use(Markdown);

registerPlugins(app);

const appStore = useAppStore();
window.addEventListener('resize', appStore.detectDeviceTypes);
appStore.detectDeviceTypes();

app.mount('#app');
