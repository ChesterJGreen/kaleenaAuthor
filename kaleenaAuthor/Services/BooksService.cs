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

        public Book Create(Book newBook)
        {
            throw new System.NotImplementedException();
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

        Book IBooksService.Create(Book newBook)
        {
            throw new System.NotImplementedException();
        }

        Book IBooksService.Edit(Book bookToEdit)
        {
            throw new System.NotImplementedException();
        }

        List<Book> IBooksService.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Book IBooksService.GetById(int bookId)
        {
            throw new System.NotImplementedException();
        }

        void IBooksService.RemoveBook(int bookId)
        {
            throw new System.NotImplementedException();
        }
    }
    
}