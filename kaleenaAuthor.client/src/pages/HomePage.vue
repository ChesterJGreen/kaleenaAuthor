<template>
  <div class="flex-grow-1 container-fluid mt-5">
    <div class="row">
      <div class="col-4 mt-5 pt-5">
        <img alt="logo" class="rounded w-100 h-75 my-5 elevation-5"
          src="src\assets\img\HeroImage.png" />
      </div>
      <div class="col-8 px-5 mt-5 text-center">
        <img class="w-100 mt-5" src="src\assets\img\Stories.png">
        <span class="f-28">Ready for a shot of <span class="selectable">Happiness?</span></span>
      </div>
    </div>
    <div class="row" id="directionsToHappinessParent">
      <div class="col-4 bg-success elevation-5" id="directionsToHappiness">
        <div class="row">
          <div class="col-12 pt-3">
            <span class="f-24 px-4 white-text-shadow">Directions to escape to</span><br>
            <span class="f-24 px-4 white-text-shadow hoverme" @click="">Happiness:</span>

            <hr />
            <hr />
          </div>
        </div>
        <div class="row">
          <div class="col-12 text-center white-text-shadow">
            <br>
            <ul>
              <span>Read stories that inspire, uplift, and entertain you</span>
            </ul>
            <ul class="text-center">
              <span> - OR -</span>
            </ul>
            <ul>
              <span>Indulge in books featuring Hot cowboys + kissing that is sweet with a brush of heat -XOXO</span>
            </ul>
            <br>
          </div>
        </div>
      </div>
      <div class="col-8">
        <p>
          <br>
          <br>
          <br>
          <br>
          <br>
          <br>
          <br>
          <br>
        </p>
      </div>
    </div>
    <div class="bg-primary mt-5 row align-items-center home">
      <div class="col-12 p-5">
        <div class=" lighten-10 row p-5">
          <div class="col-4 px-5">
            <img class="w-25 mx-3 rounded-circle border  border-info white-box-shadow"
              src="src\assets\img\LifeImage.jpeg">
          </div>
          <div class="col-4 px-5">
            <img id="imaginationPic" class="mx-3 w-50 rounded-circle border border-info"
              src="src\assets\img\BooksImage.jpeg">
          </div>
          <div class="col-4 px-5">
            <img class="w-25 h-50 mx-3 bg-white rounded-circle border border-info"
              src="src\assets\img\FaithWhiteCenter.jpeg">
          </div>
          <div class="col-4 px-5 mt-3">
            <h1 class="text-white p-3 rounded text-center black-text-shadow">
              Life
            </h1>
          </div>
          <div class="col-4 px-5 mt-3">
            <h1 class="text-white p-3 rounded text-center black-text-shadow">
              Imagination
            </h1>
          </div>
          <div class="col-4 px-5 mt-3">
            <h1 class="text-white p-3 rounded text-center black-text-shadow">
              Faith
            </h1>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>

export default {
  name: "Home",
  setup() {
    return {
      
    }
  }
}

</script>

<style scoped lang="scss">
.home {
  display: grid;
  height: 80vh;
  place-content: center;
  text-align: center;
  user-select: none;

  .home-card {
    width: 50vw;

    >img {
      height: 200px;
      max-width: 200px;
      width: 100%;
      object-fit: contain;
      object-position: center;
    }
  }
}

#directionsToHappinessParent {
  position: relative;
  width: 100vw;
}

#directionsToHappiness {
  position: absolute;
  border-bottom-right-radius: 1em;
  border-top-right-radius: 1em;
}

#imaginationPic {
  width: 88%;
}
</style>
