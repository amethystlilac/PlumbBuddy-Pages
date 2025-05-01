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

const app = createApp(App);
app.use(Markdown);

registerPlugins(app);

app.mount('#app');
