using Microsoft.AspNetCore.Mvc;

namespace ProductsMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController
    {
        protected ProductController(ILogger logger) : base(logger)
        {
        }
    }
}
