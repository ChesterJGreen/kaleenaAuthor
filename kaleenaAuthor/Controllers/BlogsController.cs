using System;
using System.Collections.Generic;
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
        private readonly IBlogsService _bs;

        public BlogsController(IBlogsService bs)
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
        [HttpGet]
        public ActionResult<Blog> GetById(int blogId)
        {
            try
            {
                Blog blog = _bs.GetById(blogId);
                return Ok(blog);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpPost]
        [Authorize]
        public ActionResult<Blog> Create([FromBody] Blog newBlog)
        {
            try 
            {
                Blog created = _bs.Create(newBlog);
                return Ok(created);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpPut]
        [Authorize]
        public ActionResult<Blog> Edit([FromBody] Blog blog)
        {
            try
            {
                Blog editedBlog = _bs.Edit(blog);
                return Ok(editedBlog);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
        [HttpDelete("{id}")]
        [Authorize]
        public void Delete(int blogId)
        {
           var blogToDelete = _bs.GetById(blogId);
           if (blogToDelete == null) throw new Exception("Blog is non-existant");
           _bs.RemoveBlog(blogToDelete.Id);
        }
    }
}