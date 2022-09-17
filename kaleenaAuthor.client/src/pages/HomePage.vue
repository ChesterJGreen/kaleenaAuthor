<template>
  <div class="flex-grow-1 container-fluid mt-5">
    <div class="row">
      <div class="col-3 mt-5">
        <img alt="logo" class="rounded w-100 my-5 elevation-5"
          src="https://i.pinimg.com/280x280_RS/97/0e/3d/970e3dcfaa84c409f7879cce2d1c653e.jpg" />
      </div>
      <div class="col-9 px-5 mt-5 text-center">
        <img class="w-100 mt-5" src="src\assets\img\Stories.gif">
        <span class="f-28">Ready for a shot of <span class="selectable">Happiness?</span></span>
      </div>
    </div>
    <div class="row" id="directionsToHappinessParent">
      <div class="col-4 bg-success elevation-5" id="directionsToHappiness">
        <div class="row">
          <div class="col-12 pt-3">
            <span class="f-24 px-4 white-text-shadow">Directions to escape to</span><br>
            <span class="f-24 px-4 white-text-shadow">Happiness:</span>
            
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
    <div class="bg-warning mt-5 row align-items-center home">
      <div class="col-12 p-5">
        <div class=" lighten-10 row p-5">
          <div class="col-4 px-5">
            <img class="w-75 mx-3 rounded-circle border  border-info white-box-shadow"
              src="https://th.bing.com/th/id/OIP.3wtQitk5ts9AzEepDVPyLAHaIy?pid=ImgDet&rs=1">
          </div>
          <div class="col-4 px-5">
            <img id="imaginationPic" class="mx-3 rounded-circle border border-info"
              src="https://www.bing.com/th?id=OIP.qtxvbuVcVvPSy-vYZlLwoQHaHa&w=250&h=250&c=8&rs=1&qlt=90&o=6&dpr=1.25&pid=3.1&rm=2">
          </div>
          <div class="col-4 px-5">
            <img class="w-75 mx-3 bg-white rounded-circle border border-info"
              src="https://th.bing.com/th/id/R.506ce96b5875a2b4ce2515a19c94f30d?rik=HmHK4w1fN4l%2feQ&riu=http%3a%2f%2fclipartix.com%2fwp-content%2fuploads%2f2016%2f04%2fAmerican-flag-united-states-flag-clipart-3-clipartcow-2.png&ehk=2uh%2fEffAtPqEiKAozxozIzyS4a0XuWVi1W60RsggWCg%3d&risl=&pid=ImgRaw&r=0">
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
import Particles from "../components/Particles.vue";

export default {
    name: "Home",
    components: { Particles }
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
