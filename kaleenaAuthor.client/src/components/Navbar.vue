<template>
  <div class="container-fluid">
    <nav class="navbar navbar-expand-lg px-5">
      <router-link class="navbar-brand d-flex" :to="{ name: 'Home' }">
        <div class="d-flex flex-column align-items-center">
        </div>
        <div class="">
          <img src="src\assets\img\LogoTransparentEnlargedCropped.png" class="rounded-pill w-50" alt="">
        </div>
      </router-link>
      <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText"
        aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon" />
      </button>
      <div class="collapse navbar-collapse" id="navbarText">
        <ul class="navbar-nav me-auto text-dark volk">
          <li>
            <router-link :to="{ name: 'About' }" class="btn text-dark selectable text-uppercase">
              About Me
            </router-link>
          </li>
          <li>
            <router-link :to="{ name: 'Books' }" class="btn text-dark selectable text-uppercase">
              Books
            </router-link>
          </li>
          <li>
            <router-link :to="{ name: 'Journeys' }" class="btn text-dark selectable text-uppercase">
              Journeys
            </router-link>
          </li>
          <li>
            <router-link :to="{ name: 'Blog' }" class="btn text-dark selectable text-uppercase">
              Blog
            </router-link>
          </li>
          <li>
            <router-link :to="{ name: 'Contact' }" class="btn text-dark selectable text-uppercase">
              Contact
            </router-link>
          </li>

          <li>
            <router-link :to="{ name: 'Admin' }" class="btn text-dark selectable text-uppercase">
              Admin Controls
            </router-link>
          </li>
        </ul>
        <ul class="navbar-nav justify-content-right justify-content-end">
          <ul>
            <a href="https://www.facebook.com/kaleena.shreeve"><img width="75"
                src="src\assets\img\facebookLogo.png"></a>
          </ul>
          <ul>
            <a href="https://www.instagram.com/kaleenashreeve1/"><img width="75"
                src="src\assets\img\InstagramLogo.png"></a>
          </ul>
          <ul>
            <a href="https://www.pinterest.com/kaleenashreeve/"><img width="75"
                src="src\assets\img\PinterestLogo.png"></a>
          </ul>
          <ul>
            <span class="p-1 ">
              <button class="btn text-white rounded-pill bg-primary volk p-1.5" data-toggle="modal" data-target="#newsletterModal">Newsletter</button>
            </span>
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
.volk {
  font-family: 'Vollkorn', serif;
  font-size: 30px;
}
button {
  font-family: cursive;
}
</style>
