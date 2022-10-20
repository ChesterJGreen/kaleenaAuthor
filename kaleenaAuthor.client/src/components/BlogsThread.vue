<template>
    <div class="row">
        <div class="col-12" v-for="b in blogs.blogs" :key="blog.id" :blog="b">
            <BlogCard />
        </div>
        <div class="col-12">

        </div>
    </div>
</template>
<script>

</script>
<style>
</style>