<template>
  <header>
    <Navbar />
  </header>
  <main>
    <router-view />
  </main>
  <footer>
    <FooterNavbar />
  </footer>
</template>

<script>
import { computed } from 'vue';
import { AppState } from './AppState';
import BookUpdates from './components/BookUpdates.vue';
import FooterNavbar from './components/FooterNavbar.vue';

export default {
  name: "App",
  setup() {
    return {
      appState: computed(() => AppState)
    };
  },
  components: { BookUpdates, FooterNavbar }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";
</style>
