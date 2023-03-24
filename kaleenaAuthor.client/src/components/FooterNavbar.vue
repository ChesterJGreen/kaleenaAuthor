<template>
  <div class="container-fluid">
    <nav class="navbar navbar-expand-lg px-5">
      <router-link class="navbar-brand d-flex" :to="{ name: 'Home' }">
        <div class="d-flex flex-column align-items-center">
        </div>
        <div class="">
          <img src="src\assets\img\Transparent Logo Cropped.png" class="rounded-pill w-50" alt="">
        </div>
      </router-link>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText"
        aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon" />
      </button>
      <div class="collapse navbar-collapse" id="navbarText">
        <ul class="navbar-nav me-auto text-dark">
          <li>
            <router-link :to="{ name: 'About' }" class="btn text-success darken-30 selectable text-uppercase">
              About Me
            </router-link>
          </li>
          <li>
            <router-link :to="{ name: 'Books' }" class="btn text-success darken-30 selectable text-uppercase">
              Books
            </router-link>
          </li>
          <li>
            <router-link :to="{ name: 'Contact' }" class="btn text-success darken-30 selectable text-uppercase">
              Contact
            </router-link>
          </li>
        </ul>
        <ul class="navbar-nav justify-content-right justify-content-end">
          <ul>
            <a href="https://www.facebook.com/kaleena.shreeve"><img width="25"
                src="src\assets\img\f_logo_RGB-Black_144.png"></a>
          </ul>
          <ul>
            <a href="https://www.instagram.com/kaleenashreeve1/"><img width="25"
                src="src\assets\img\Instagram_Glyph_Black.png"></a>
          </ul>
          </ul>
      </div>
    </nav>
  </div>
  
</template>

<script>
export default {
  setup() {
    return {};
  },
};
</script>

<style scoped>
a:hover {
  text-decoration: none;
}

.nav-link {
  text-transform: uppercase;
}

.navbar-nav .router-link-exact-active {
  border-bottom: 2px solid var(--bs-success);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
}
li {
  font-family: cursive;
}
button {
  font-family: cursive;
}
</style>
