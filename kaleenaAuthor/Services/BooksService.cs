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
            return _repo.Create(newBook);
        }

        public Book Edit(Book bookToEdit)
        {
            return _repo.Edit(bookToEdit);
        }

        public List<Book> GetAll()
        {
            return _repo.GetAll();
        }

        public Book GetById(int bookId)
        {
            return _repo.GetById(bookId);
        }

        public void RemoveBook(int bookId)
        {
            _repo.RemoveBook(bookId);
        }
    }
    
}