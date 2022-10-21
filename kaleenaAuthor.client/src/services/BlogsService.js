import { AppState } from '../AppState'
import { logger } from '../utils/Logger'
import { api } from './AxiosService'

class BlogsService {
    async getAll() {
        const res = await api.get('api/blogs')
        logger.log(res.data)
        AppState.blogs = res.data
    }
}
export const blogsService = new BlogsService()