<template>
    <div class="about container-fluid my-5">
      <div class="row">
        <div class="clo-12 my-5">
          <div class="row">
            <div class="col-4 my-5 px-5">
              <h1 class="border ps-4 py-3 elevation-1 rounded bg-info text-light">This is the Blog page</h1>
            </div>
          </div>
          <div class="row">
            <div class="col-8">
              <BlogPost :blogs="blogs" />
            </div>
          </div>
        </div>
      </div>
    </div>
  </template>
  
  <script>
  export default {
    name: 'BlogPage'
  }
  </script>
  