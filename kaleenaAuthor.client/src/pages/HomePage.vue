<template>
  <div class="flex-grow-1 container-fluid">
    <div class="row">
      <div class="col-12 my-5" id="HeroImg">
        <img alt="logo" class=" w-100"
        src="src\assets\img\womanWalking.jpg.jpg" />
      </div>
      <div class="col-12">
        <div class="row">
          <div class="col-5 offset-6" id="LoveStoryTxt">
            <p class="text-white text-center">LIVE IN A</p>
            <p class="text-white text-center">LOVE STORY</p>
          </div>
        </div>

      </div>
      
      
    </div>
   
    <div class="row">
            <div class="col-8">
                <div class="row">
                    <div class="col-12 p-4">
                        Premium Reading Experience
                    </div>
                    <div class="col-12 text-center p-4 d-flex align-items-end">
                        Site Ingredients: Love, Happiness, Truth, Creativity, Cowboys, Romance, Kissing, Heartstrings,
                        Happily Ever Afters
                    </div>
                </div>
            </div>
            <div class="col-3 bg-success rounded">
                <div class="row">
                    <div class="col-12 text-center mt-2">
                        <span>Progress Bar</span>
                        <hr class="striped-border">
                    </div>
                    <div class="pb-3"><span>Stolen Heart</span>
                        <div class="progress">
                            <div class="progress-bar text-dark progress-bar-striped progress-bar-animated"
                                role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"
                                style="width: 75%">75%</div>
                        </div>
                    </div>
                    <div class="pb-3"><span>Christmas Novela</span>
                        <div class="progress">
                            <div class="progress-bar text-dark progress-bar-striped progress-bar-animated"
                                role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"
                                style="width: 20%">20%</div>
                        </div>
                    </div>
                    <div class="pb-3"><span>Night Train</span>
                        <div class="progress">
                            <div class="progress-bar text-dark progress-bar-striped progress-bar-animated"
                                role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100"
                                style="width: 30%">30%</div>
                        </div>
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
#HeroImg {
  position: relative;
}
#LoveStoryTxt {
  position: absolute;
  left: 1.5em;
  top: 3em;
  font-size: 500%;
  font-family:'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
  text-shadow: 2px 1px 1px rgba(0,0,0,0.5)
}
</style>
