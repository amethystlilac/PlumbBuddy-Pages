/**
 * plugins/vuetify.js
 *
 * Framework documentation: https://vuetifyjs.com`
 */

// Styles
import '@mdi/font/css/materialdesignicons.css';
import 'vuetify/styles';

// Composables
import { createVuetify } from 'vuetify';

// https://vuetifyjs.com/en/introduction/why-vuetify/#feature-guides
export default createVuetify({
    theme: {
        defaultTheme: 'dark',
        themes: {
            light: {
                dark: false,
                colors: {
                    primary: '#00a2ff',
                    secondary: '#ff4081',
                    tertiary: '#74c044',
                    warning: '#d98806',
                },
            },
            dark: {
                dark: true,
                colors: {
                    primary: '#00a2ff',
                    secondary: '#ff4081',
                    tertiary: '#74c044',
                    warning: '#d98806',
                },
            },
        },
    },
});
