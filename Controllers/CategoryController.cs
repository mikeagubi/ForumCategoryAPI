using CategoryAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CategoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryManager _categoryManager;
        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        [HttpGet]
        public async Task<List<Models.Category>> Get()
        {
            var categories = await _categoryManager.GetCategories();
            return categories;
        }

        [HttpPost]
        public async Task Post([FromBody] Models.Category category)
        {
            await _categoryManager.AddCategory(category);
        }
    }
}
