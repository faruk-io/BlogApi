using BlogApi.Data;
using BlogApi.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
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
        public async Task<IActionResult> GetAllCategory()
        {
            var CategoryList = await _repository.GetAll();
            return Ok(CategoryList);
        }
    }
}
