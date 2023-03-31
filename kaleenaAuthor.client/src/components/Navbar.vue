<template>
  <div class="container-fluid">
    <nav class="row navbar navbar-expand-lg">
      <div class="col-12">
        <div class="row">
          <div class="col-10">
          </div>
          <div class="col-2 p-2" id="SweetBites">
            <img src="src\assets\img\Arrow.png" class="w-25" id="Arrow">
            <span class="text-start" id="SBText">Sweet Bites</span>
          </div>
        </div>
        <div class="row">
          <div class="col-3">
            <router-link class="navbar-brand d-flex" :to="{ name: 'Home' }">
              <div class="d-flex flex-column align-items-center">
                <img src="src\assets\img\LogoTransparentEnlargedCropped.png" class="rounded-pill w-75" alt="">
              </div>
            </router-link>
          </div>
          <div class="col-9">
            <div class="collapse navbar-collapse pt-3" id="navbarText">
              <ul class="navbar-nav justify-content-right justify-content-end">
                <ul class="navbar-nav me-auto text-dark volk">
                  <div class="row">
                    <div class="col-9">
                      <li>
                        <router-link :to="{ name: 'About' }" class="router btn text-dark selectable text-uppercase">
                          About Me
                        </router-link>
                      </li>
                      <li>
                        <router-link :to="{ name: 'Books' }" class="router btn text-dark selectable text-uppercase">
                          Books
                        </router-link>
                      </li>
                      <li>
                        <router-link :to="{ name: 'Journeys' }" class="router btn text-dark selectable text-uppercase">
                          Journeys
                        </router-link>
                      </li>
                      <li>
                        <router-link :to="{ name: 'Blog' }" class="router btn text-dark selectable text-uppercase">
                          Blog
                        </router-link>
                      </li>
                      <li>
                        <router-link :to="{ name: 'Contact' }" class="router btn text-dark selectable text-uppercase">
                          Contact
                        </router-link>
                      </li>
                    </div>
                    <div class="col-4">
                      <li>
                        <a href="https://www.facebook.com/kaleena.shreeve"><img width="75"
                            src="src\assets\img\facebookLogo.png"></a>
                      </li>
                      <li>
                        <a href="https://www.instagram.com/kaleenashreeve1/"><img width="75"
                            src="src\assets\img\InstagramLogo.png"></a>
                      </li>
                      <li>
                        <a href="https://www.pinterest.com/kaleenashreeve/"><img width="75"
                            src="src\assets\img\PinterestLogo.png"></a>
                      </li>
                      <li>
                        <span class="p-1 ">
                          <button class="btn text-white rounded-pill bg-primary volk p-1.5" data-toggle="modal"
                            data-target="#newsletterModal">Newsletter</button>
                        </span>
                      </li>
                    </div>
                  </div>
                </ul>
              </ul>
            </div>
          </div>

          <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText"
            aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon" />
          </button>
        </div>
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

.router {
  font-size: 85%;
}

button {
  font-family: cursive;
}

#SweetBites {
  position: relative;
}

#Arrow {
  position: absolute;
  top: 1em;
  left: 0;
}

#SBText {
  position: absolute;
  top: 0;
  left: 1.5em;
  font-size: xx-large;
  font-family: 'Lora', serif;
}
</style>
