using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kaleenaAuthor.Models;
using kaleenaAuthor.Services;
using Microsoft.AspNetCore.Mvc;

namespace kaleenaAuthor.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class BlogsController : ControllerBase
    {
        private readonly BlogsService _bs;

        public BlogsController(BlogsService bs)
        {
            _bs = bs;
        }

        [HttpGet]
        public ActionResult<List<Blog>> Get()
        {
            try
            {
                List<Blog> blogs = _bs.Get();
                return Ok(blogs);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}