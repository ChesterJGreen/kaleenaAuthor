import { AppState } from '../AppState'

class BlogsService {
    async getAll() {
        const res = await api.get('api/blogs')
        logger.log(res.data)
        AppState.blogs = res.data
    }
}
export const blogsService = new BlogsService()