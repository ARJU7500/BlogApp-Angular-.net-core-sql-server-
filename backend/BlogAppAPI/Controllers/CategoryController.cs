using BlogAppAPI.Data;
using BlogAppAPI.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IRepository<Category> _repository;
        public CategoryController(IRepository<Category> repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult> getAllCategory()
        {
            var CategotyList = await _repository.GetAllData();
                return Ok(CategotyList);
        }
    }
}
