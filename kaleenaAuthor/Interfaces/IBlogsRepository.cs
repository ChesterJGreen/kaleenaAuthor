using System.Collections.Generic;
using kaleenaAuthor.Models;

namespace kaleenaAuthor.Interfaces
{
    public interface IBlogsRepository
    {
        internal List<Blog> GetAll();
        internal Blog GetById(int blogId);
        internal Blog Create(Blog newBlog);
        internal Blog Edit(Blog blogToEdit);
        internal void RemoveBlog(int blogId); 
    }
}