using Microsoft.AspNetCore.Mvc;
using ProductsMicroService.Application.DTO.Category;
using ProductsMicroService.Application.Interfaces;

namespace ProductsMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ILogger logger, ICategoryService categoryService) : base(logger)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var data = _categoryService.GetCategories();
            return Ok(data);

        }

        /// <summary>
        /// Add new Category
        /// </summary>
        /// <param name="categoryDto"></param>
        /// <returns></returns>
        //[Authorize(Roles = "admin")]
        [HttpPost]
        public IActionResult Post([FromBody] CategoryDto categoryDto)
        {
            _categoryService.AddNewCategory(categoryDto);
            return Ok();
        }
    }
}
