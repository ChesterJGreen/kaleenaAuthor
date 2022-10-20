<template>
    <div class="row">

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