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
        List<Book> books = GetSomeFakeBooks();
        return books;    
    }
    public Book GetById(int bookId)
    {
        List<Book> books = GetSomeFakeBooks();
        Book book = books.Find(x => x.Id == bookId);
        return book; 
    }

    public List<Book> GetSomeFakeBooks()
    {
        var book1 = new Book()
        {
            Id = 1,
            Name = "Book 1",
            ProgressPercent = 90,
            Image = "https://www.hostinger.com/tutorials/wp-content/uploads/sites/2/2022/03/what-is-a-blog.png"
        };
        var book2 = new Book()
        {
            Id = 2,
            Name = "Book 2",
            ProgressPercent = 50,
            Image = "https://www.hostinger.com/tutorials/wp-content/uploads/sites/2/2022/03/what-is-a-blog.png"
        };
        var book3 = new Book()
        {
            Id = 3,
            Name = "Book 3",
            ProgressPercent = 24,
            Image = "https://www.hostinger.com/tutorials/wp-content/uploads/sites/2/2022/03/what-is-a-blog.png"
        };
        List<Book> books = new List<Book>();
        books.Add(book1);
        books.Add(book2);
        books.Add(book3);
        return books;    
    }

    public void RemoveBook(int bookId)
    {
        throw new System.NotImplementedException();
    }
}