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
        public List<Blog> GetAll()
        {
            return _repo.GetAll();
        }
        public 
    }
}