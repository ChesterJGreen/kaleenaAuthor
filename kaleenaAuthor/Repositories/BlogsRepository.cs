using System.Collections.Generic;
using System.Data;
using kaleenaAuthor.Models;

namespace kaleenaAuthor.Repositories
{
    public class BlogsRepository
    {
        private readonly IDbConnection _db;
        public BlogsRepository(IDbConnection db)
        {
            _db = db;
        }

        internal List<Blog> GetAll()
        {
            var blogs = GetSomeFakeBlogs(); 
            return blogs;
        }
        internal List<Blog> GetSomeFakeBlogs()
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
    }
}