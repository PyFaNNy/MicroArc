using Microsoft.AspNetCore.Mvc;

namespace ProductsMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController
    {
        protected CategoryController(ILogger logger) : base(logger)
        {
        }
    }
}
