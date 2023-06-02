<template>
  <div class="flex-grow-1 container-fluid">
    <div class="row">
      <div class="col-12 my-3"></div>
      <div class="col-12 p-0" id="HeroImg">
        <img alt="logo" class=" w-100" src="src\assets\img\HomPageHeroImg.jpg" />
      </div>
    </div>
    <div class="row">
      <div class="col-12">
        <div class="row">
          <div class="col-5 mt-5" id="LoveStoryTxt">
            <br>
            <p class="text-white text-center">LIVE IN A</p>
            <p class="text-white text-center">LOVE STORY</p>
          </div>
          <div class="row">
            <div class="col-5" id="KaleenaCowboyHat">
              <img class="rounded-pill" src="src\assets\img\KaleenaCirclePortraitCowboyHat.jpg" />
            </div>
          </div>
        </div>
      </div>

      <div class="col-12">
      </div>


    </div>
    <div class="row">
      <div class="col-12 bg-offWhite py-5">
        <span class="ps-5 FeelTheSighText">Feel the sigh and experience the fireworks.</span>
        <div class="text-center ps-5 offset-3"> 
          <span class=" text-center FeelTheSighText">- XOXO Kaleena</span>
        </div>
      </div>
    </div>
    <div class="row">
      
    </div>


    <div class="row mt-5">
      <div class="col-6">
        <div class="row">
          <div class="col-3 text-center">
            <img src="src\assets\img\CowboyBlack.png" width="150">
          </div>
          <div class="col-9 text-center ifStatements px-4">
            <button class="btn text-black rounded-pill bg-primary p-1.5 py-2 px-3 rochester" data-toggle="modal"
                            data-target="">c l i c k &nbsp&nbsp h e r e</button>
            <p class="mt-3">if a <b>hot cowboy</b></p>
            <p>staring at you would make you blush</p>
          </div>

        </div>
        
      </div>
      <div class="col-6">
        <div class="row">
          <div class="col-9 text-center ifStatements px-4">
            <button class="btn text-black rounded-pill bg-primary p-1.5 py-2 px-3 rochester" data-toggle="modal"
            data-target="">c l i c k &nbsp&nbsp h e r e</button>
            <p class="mt-3">if you believe</p>
            <p><b>love and romance</b> is all around you</p>
          </div>
          <div class="col-3">
            <img src="src\assets\img\CoupleKissing.png" width="150">
          </div>
          
        </div>

      </div>

    </div>
    <FooterNavbarVue />
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

#HeroImg {
  position: relative;
}

#LoveStoryTxt {
  position: absolute;
  left: -0.75em;
  top: 3em;
  font-size: 500%;
  font-family: 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
  text-shadow: 2px 1px 1px rgba(0, 0, 0, 0.5)
}
#KaleenaCowboyHat {
  position: absolute;
  right: -16em;
  top: 30em;
}

.FeelTheSighText {
  font-size: 350%;
  font-family: 'Yesteryear', cursive;

}

.bg-offWhite {
  background-color: rgba(246, 246, 235);
}
.ifStatements {
  font-size: x-large;
  font-family:'Courier New', Courier, monospace ;
}
.rochester {
  font-size: larger;
  font-family: 'Rochester', 'Times New Roman', Times, serif;
}

</style>
