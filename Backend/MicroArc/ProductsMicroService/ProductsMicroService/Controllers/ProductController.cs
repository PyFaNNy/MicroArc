using Microsoft.AspNetCore.Mvc;
using ProductsMicroService.Application.Interfaces;

namespace ProductsMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        public ProductController(ILogger logger, IProductService productService) : base(logger)
        {
            _productService = productService;
        }

        /// <summary>
        /// Get Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var data = _productService.GetProductList();
            return Ok(data);
        }

        /// <summary>
        /// Get specific product
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var data = _productService.GetProduct(id);
            return Ok(data);
        }
    }
}
