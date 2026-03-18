using BlogAppAPI.Data;
using BlogAppAPI.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BlogAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogMasterController : ControllerBase
    {
        //Create a variable a variable for store data
        private readonly IRepository<Blog> _blogRepository;
        //create constructure
        public BlogMasterController(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetBlogList()
        {
            //create variable blog for where we have data 
            var blogs = await _blogRepository.GetAllData();
            return Ok(blogs);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetBlog([FromRoute] int id)
        {
            var blog = await _blogRepository.GetById(id);
            return Ok(blog);
        }
        [HttpPost]
        public async Task<ActionResult> AddBlog([FromBody] Blog model)
        {
            await _blogRepository.AddAsync(model);
            await _blogRepository.SaveChangeAsnc();
            return Ok(model);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> updateBlog([FromRoute] int id, [FromBody] Blog model)
        {
            var blog = await _blogRepository.GetById(id);
            blog.Description = model.Description;
            blog.Title = model.Title;
            blog.Content = model.Content;
            blog.image = model.image;
            blog.isFetured = model.isFetured;
            blog.CategoryId = model.CategoryId;
            blog.UpdatedBy = model.UpdatedBy;
            blog.UpdatrdOn = model.UpdatrdOn;
            _blogRepository.Update(blog);
            await _blogRepository.SaveChangeAsnc();
            return Ok(model);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteBlog([FromRoute] int id)
        {
            await _blogRepository.DeleteAsync(id);
            await _blogRepository.SaveChangeAsnc(); //like an commit
            return Ok();
        }

        [HttpGet("featured")]
        public async Task<ActionResult> GetFeaturedBlog()
        {
            var blog = await _blogRepository.GetAllData(x => x.isFetured == true);
            return Ok(blog);
        }
    }
}
