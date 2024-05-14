using BookingApp.ApplicationLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly CategoryService _categoryService;
        public CategoryController(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("CategoryList")]
        public async Task<IActionResult> CategoryList()
        {
            var categorylist = await _categoryService.GetAllAsync();
            return Ok(categorylist);
        }
    }
}
