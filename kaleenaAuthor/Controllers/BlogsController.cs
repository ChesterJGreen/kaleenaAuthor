using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kaleenaAuthor.Models;
using kaleenaAuthor.Services;
using Microsoft.AspNetCore.Mvc;

namespace kaleenaAuthor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly BlogsService _bs;

        public BlogsController(BlogsService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<List<Blog>> GetAll()
        {
            try
            {
                List<Blog> blogs = _bs.GetAll();
                return Ok(blogs);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}