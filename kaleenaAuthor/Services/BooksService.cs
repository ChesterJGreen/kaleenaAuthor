using kaleenaAuthor.Interfaces;
using kaleenaAuthor.Models;
using System.Collections.Generic;

namespace kaleenaAuthor.Services
{
    public class BooksService : IBooksService
    {
        private readonly IBooksRepository _repo;

        public BooksService(IBooksRepository repo)
        {
            _repo = repo;
        }

        Blog IBooksService.Create(Blog newBlog)
        {
            throw new System.NotImplementedException();
        }

        Blog IBooksService.Edit(Blog blogToEdit)
        {
            throw new System.NotImplementedException();
        }

        List<Blog> IBooksService.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Blog IBooksService.GetById(int blogId)
        {
            throw new System.NotImplementedException();
        }

        void IBooksService.RemoveBook(int blogId)
        {
            throw new System.NotImplementedException();
        }
    }
    
}