<template>
  <div id="site-background"></div>
  <v-main>
    <router-view />
  </v-main>

  <AppFooter />
</template>

<script setup>
  //
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