using System.Collections.Generic;
using kaleenaAuthor.Models;
using kaleenaAuthor.Interfaces;

namespace kaleenaAuthor.Services
{
    public class BlogsService : IBlogsService
    {
        private readonly IBlogsRepository _repo;

        public BlogsService(IBlogsRepository repo)
        {
            _repo = repo;
        }
        public List<Blog> GetAll()
        {
            return _repo.GetAll();
        }
        public Blog GetById(int blogId)
        {
            return _repo.GetById(blogId);
        }
        public Blog Create(Blog newBlog)
        {
            return _repo.Create(newBlog);
        }

        public Blog Edit(Blog blog)
        {
            Blog oldBlog = GetById(blog.Id);
            Blog editedBlog = new Blog();
            _repo.Edit(editedBlog);
            return blog;
        }
        public void RemoveBlog(int blogId)
        {
            _repo.RemoveBlog(blogId);
        }
    }
}