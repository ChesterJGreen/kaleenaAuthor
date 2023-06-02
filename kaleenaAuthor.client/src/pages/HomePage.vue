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
        <span class="ps-5 FeelTheSighText Yesteryear">Feel the sigh and experience the fireworks.</span>
        <div class="text-center ps-5 offset-3"> 
          <span class=" text-center FeelTheSighText Yesteryear">- XOXO Kaleena</span>
        </div>
      </div>
    </div>
    <div class="row">
        <div class="clo-12 mt-5">
          <h1 class="text-center Volk fs300"><b>Lonely Cowboy Hearts Series</b></h1>
        </div>
      </div>
      <div class="row mt-5">
        <div class="col-3 p-0">
          <img src="src\assets\img\stolen-heart-img.png" width="600">
        </div>
        <div class="col-6 offset-2">
          <h2 class="text-center Yesteryear Description">Gavin is a lonely cowboy. Sarah needs a fresh start.</h2>
          <p></p>
          <h3 class="text-center Prata fs150"><p>A modern day arranged marriage ropes them together, </p>
            <p> but will the tethers that bind them be strong </p>
            <p> enough to overcome their explosive beginning?</p>
            <p><a class="text-center Volk fs50"><u>R E A D &nbsp M O R E</u></a></p>
          </h3>
          <br>
          <h6 class="text-center ZillaSlab">
            <p>"Had we been associated under different circumstances, I would have chased you and your beautiful</p>
            <p>shiny red hair and gemstone eyes, until you would have know that there isn't another woman in</p>
            <p>the world, that a man wanted more than I want you."</p>
            <p class="text-end Yesteryear fs200">- Gavin</p>
          </h6>
          <br>
          <h6 class="text-center ZillaSlab">
            <p>"Gentle fingers below her chin raised her lips to his own. His mouth was soft and inviting and she</p>
            <p>reciprocated the kisses born of affection. Each spoke of trust, something she had always wanted,</p>
            <p>but now could not afford."</p>
            <p class="text-end Yesteryear fs200">- Sarah</p>
          </h6>

        </div>
        
        
      </div>
      <div class="row mt-5">
        <div class="col-5 text-center"><button class="rounded"><a>Buy on Amazon</a></button></div>
        <div class="col-4 offset-2 border rounded p-5">
          <p><h2 class="text-center">Books Progres Bars</h2></p>
          <p><h6>Cowboy Christmas Novella</h6></p>
          <p><h6>Secret Heart--Lonely Cowboy Hearts Book 2</h6></p>
        </div>
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
}
.Description {
  font-size: 250%;;
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
