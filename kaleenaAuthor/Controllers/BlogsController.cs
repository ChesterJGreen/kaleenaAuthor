using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using kaleenaAuthor.Models;
using kaleenaAuthor.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace kaleenaAuthor.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Blog>> Create([FromBody] Blog newBlog)
        {
            try{
                bool userInfo = await HttpContext.User.FindFirst(System.Security.Claims.Claim);
                if (userInfo)
                {
                Blog created = _bs.Create(newBlog);
                return Ok(created);
                }
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}