using Microsoft.AspNetCore.Mvc;

namespace ProductsMicroService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductManagementController : BaseController
    {
        protected ProductManagementController(ILogger logger) : base(logger)
        {
        }
    }
}
