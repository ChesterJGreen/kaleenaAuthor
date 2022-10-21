<template>
    <div class="row">
        <div class="col-4">
            <div class="row">
                <div class="col-12">
                    <span>{{ blog.name }}</span>
                </div>
            </div>
            <div class="row">
                <div class="col-12">
                    <img :src="blog.img" class="card-img card-bottom card-top">
                </div>
            </div>
        </div>
        <div class="col-8">
            <div class="row">
                <div class="col-12">
                    <span> {{ blog.body }}</span>
                </div>
            </div>
        </div>
    </div>
</template>

<script>
import { computed, reactive } from '@vue/runtime-core'
import { AppState } from '../AppState'

export default {
    name: 'BlogCard',
    props: {
        blog: {
            type: Object,
            required: true
        }
    },
    setup(props) {
        const state = reactive({
            blog: blogs.blog
        })
        return {
            state,
            blogs: computed(() => AppState.blogs)
        }
    }
}
</script>
<style>

</style>