<template>
  <div class="about container-fluid my-5">
    <div class="row">
      <div class="col-12 mt-5">
        <div class="row">
          <div class="col-3 text-center offset-4 hover mt-5">
            <div class="card bg-dark text-white">
              <div class="card">
                <h5 class="card-title"><span class="text-dark">Here are the Admin Controls!</span></h5>
              </div>
            </div>
          </div>
          <div class="col-6  offset-3 mt-5">
            <form>
              <div class="form-group text-center">
                <label for="exampleFormControlInput1">Book Title</label>
                <input type="text" class="form-control" id="exampleFormControlInput1" placeholder="Book Name">
              </div>
              <div class="form-group text-center">
                <label for="exampleFormControlInput1">Progress Percentage</label>
                <input type="number" max="100" min="0" class="form-control" id="exampleFormControlInput1" placeholder="Percentage">
              </div>
              <div class="form-group">
                <label for="exampleFormControlSelect1">Example select</label>
                <select class="form-control" id="exampleFormControlSelect1">
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                </select>
              </div>
              <div class="form-group">
                <label for="exampleFormControlSelect2">Example multiple select</label>
                <select multiple class="form-control" id="exampleFormControlSelect2">
                  <option>1</option>
                  <option>2</option>
                  <option>3</option>
                  <option>4</option>
                  <option>5</option>
                </select>
              </div>
              <div class="form-group">
                <label for="exampleFormControlTextarea1">Example textarea</label>
                <textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>
              </div>
            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
  
<script>
export default {
  name: 'Admin'
}
</script>
  