using kaleenaAuthor.Repositories;
using System.Collections.Generic;
using kaleenaAuthor.Models;

namespace kaleenaAuthor.Services
{
    public class BlogsService
    {
        private readonly BlogsRepository _repo;

        public BlogsService(BlogsRepository repo)
        {
            _repo = repo;
        }
        internal List<Blog> GetAll()
        {
            return _repo.GetAll();
        }
        internal Blog GetById(int blogId)
        {
            return _repo.GetById(blogId);
        }
        internal Blog Create(Blog newBlog)
        {
            return _repo.Create(newBlog);
        }

        internal Blog Edit(Blog blog)
        {
            Blog oldBlog = GetById(blog.Id);
            Blog editedBlog = new Blog();
            _repo.Edit(editedBlog);
            return blog;
        }
        internal void RemoveBlog(int blogId)
        {
            _repo.RemoveBlog(blogId);
        }
    }
}