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

    public Book Create(Book newBook)
    {
        throw new System.NotImplementedException();
    }

    public Book Edit(Book bookToEdit)
    {
        throw new System.NotImplementedException();
    }

    public List<Book> GetAll()
    {
        throw new System.NotImplementedException();
    }

    public Book GetById(int bookId)
    {
        throw new System.NotImplementedException();
    }

    public List<Book> GetSomeFakeBooks()
    {
        throw new System.NotImplementedException();
    }

    public void RemoveBook(int bookId)
    {
        throw new System.NotImplementedException();
    }
}