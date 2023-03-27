using Microsoft.AspNetCore.Mvc;
using ProductsMicroService.Application.DTO.Product;
using ProductsMicroService.Application.Interfaces;

namespace ProductsMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "admin")]
    public class ProductManagementController : BaseController
    {
        private readonly IProductService _productService;
        public ProductManagementController(ILogger logger, IProductService productService) : base(logger)
        {
            _productService = productService;
        }

        /// <summary>
        /// Add new Product
        /// </summary>
        /// <param name="addNewProductDto"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] AddNewProductDto addNewProductDto)
        {
            var productId = _productService.AddNewProduct(addNewProductDto);
            return Created($"/api/ProductManagement/get/{productId}", productId);
        }

        /// <summary>
        /// Get Products
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var products = _productService.GetProductList();
            return Ok(products);
        }

        /// <summary>
        /// Get specific Product
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        public IActionResult Get(Guid Id)
        {
            var product = _productService.GetProduct(Id);
            return Ok(product);
        }

    }
}
