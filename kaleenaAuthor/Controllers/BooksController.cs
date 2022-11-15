using Microsoft.AspNetCore.Mvc;
using kaleenaAuthor.Interfaces;


namespace kaleenaAuthor.Controllers
{
    [ApiController]
    [Route("api/blogs")]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _bs;

        public BooksController(IBooksService bs)
        {
            _bs = bs;
        }
        
    }
}
