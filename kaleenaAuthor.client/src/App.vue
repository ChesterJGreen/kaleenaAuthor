<template>
  <header>
    <Navbar />
  </header>
  <main>
    <router-view />
  </main>
  <footer>
    <BookUpdates />
  </footer>
</template>

<script>
import { computed } from 'vue';
import { AppState } from './AppState';
import BookUpdates from './components/BookUpdates.vue';

export default {
  name: "App",
  setup() {
    return {
      appState: computed(() => AppState)
    };
  },
  components: { BookUpdates }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";
</style>
