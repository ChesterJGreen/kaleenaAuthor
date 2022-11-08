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
import { computed } from '@vue/reactivity';
import { AppState } from '../AppState';


export default {
    name: 'BlogsThread',
    props: {
        blogs: {
            type: Object,
            required: true
        },
        blog: {
            type: Object,
            required: true
        }
    },
    setup(props) {
        return {
            blogs: computed(() => AppState.blogs)
        }
    }
}
</script>
<style>
</style>