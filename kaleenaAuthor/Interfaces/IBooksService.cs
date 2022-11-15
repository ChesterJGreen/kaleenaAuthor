using System.Collections.Generic;
using kaleenaAuthor.Models;

namespace kaleenaAuthor.Interfaces
{
    public interface IBooksService
    {
        public List<Book> GetAll();
        public Book GetById(int bookId);
        public Book Create(Book newBook);
        public Book Edit(Book bookToEdit);
        public void RemoveBook(int bookId); 
    }
}