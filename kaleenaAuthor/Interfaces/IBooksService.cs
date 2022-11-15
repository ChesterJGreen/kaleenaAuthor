using System.Collections.Generic;
using kaleenaAuthor.Models;

namespace kaleenaAuthor.Interfaces
{
    public interface IBooksService
    {
        public List<Blog> GetAll();
        public Blog GetById(int blogId);
        public Blog Create(Blog newBlog);
        public Blog Edit(Blog blogToEdit);
        public void RemoveBook(int blogId); 
    }
}