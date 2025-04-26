<template>
    <v-breadcrumbs
        bg-color="info"
        :items="[{title: 'PlumbBuddy.app', to: '/'}, {title: 'HTTP 404 — Not Found'}]"
    />
    <div class="main-container">
        <Display404 />
    </div>
</template>
