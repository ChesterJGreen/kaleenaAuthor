using System.Collections.Generic;
using System.Data;
using kaleenaAuthor.Models;
using kaleenaAuthor.Interfaces.IBlogsRepository;

namespace kaleenaAuthor.Repositories
{
    public class BlogsRepository : IBlogsRepository
    {
        private readonly IDbConnection _db;
        public BlogsRepository(IDbConnection db)
        {
            _db = db;
        }

        public List<Blog> GetAll()
        {
            List<Blog> blogs = GetSomeFakeBlogs(); 
            return blogs;
        }
        public Blog GetById(int blogId)
        {
            List<Blog> blogs = GetSomeFakeBlogs();
            Blog blog = blogs.Find(x => x.Id == blogId);
            return blog;
        }
        public Blog Create(Blog newBlog)
        {
            return newBlog;
        }


        public List<Blog> GetSomeFakeBlogs()
        {
            var blog1 = new Blog()
            {
                Id = 1,
                Body = "Here is a string for a body.",
                Name = "Blog1"        
            };
            var blog2 = new Blog()
            {
                Id = 2,
                Body = "Here is a 2nd body",
                Name = "Blog2",
                Image = "https://www.hostinger.com/tutorials/wp-content/uploads/sites/2/2022/03/what-is-a-blog.png"

            };
            var blog3 = new Blog()
            {
                Id = 3,
                Body = "here is a 3rd body",
                Name = "Blog3",
                Image = "https://arthurfindelair.com/thisnightskydoesnotexist/"
            };
            List<Blog> blogs = new List<Blog>();
            blogs.Add(blog1);
            blogs.Add(blog2);
            blogs.Add(blog3);
            return blogs;

        }

        public void RemoveBlog(int blogId)
        {
            List<Blog> blogs = GetSomeFakeBlogs();
            Blog blogToDelete = GetById(blogId);
            blogs.Remove(blogToDelete);
        }

        public Blog Edit(Blog editedBlog)
        {
            List<Blog> blogs = GetSomeFakeBlogs();
            Blog blogToEdit = new Blog();
            return blogToEdit;
        }
    }
}