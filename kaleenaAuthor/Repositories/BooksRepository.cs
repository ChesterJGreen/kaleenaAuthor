using System.Collections.Generic;
using System.Data;
using kaleenaAuthor.Interfaces;
using kaleenaAuthor.Models;

namespace kaleenaAuthor.Repositories;

public class BooksRepository : IBooksRepository
{
     private readonly IDbConnection _db;
        public BooksRepository(IDbConnection db)
        {
            _db = db;
        }

    Blog IBooksRepository.Create(Blog newBlog)
    {
        throw new System.NotImplementedException();
    }

    Blog IBooksRepository.Edit(Blog blogToEdit)
    {
        throw new System.NotImplementedException();
    }

    List<Blog> IBooksRepository.GetAll()
    {
        throw new System.NotImplementedException();
    }

    Blog IBooksRepository.GetById(int blogId)
    {
        throw new System.NotImplementedException();
    }

    List<Blog> IBooksRepository.GetSomeFakeBooks()
    {
        throw new System.NotImplementedException();
    }

    void IBooksRepository.RemoveBook(int blogId)
    {
        throw new System.NotImplementedException();
    }
}