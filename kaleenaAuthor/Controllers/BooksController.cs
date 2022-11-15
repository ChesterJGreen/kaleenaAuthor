using Microsoft.AspNetCore.Mvc;
using kaleenaAuthor.Interfaces;
using kaleenaAuthor.Models;
using System.Collections.Generic;
using System;

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
        [HttpGet]
        public ActionResult<List<Book>> GetAll()
        {
            try
            {
                List<Book> books = _bs.GetAll();
                return Ok(books);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
