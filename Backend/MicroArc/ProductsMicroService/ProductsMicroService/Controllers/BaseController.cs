using Microsoft.AspNetCore.Mvc;

namespace ProductsMicroService.Controllers
{
    public class BaseController : ControllerBase
    {
        protected ILogger Logger
        {
            get;
        }

        //private IMediator? _mediator;

        //protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        protected BaseController(ILogger logger)
        {
            Logger = logger;
        }
    }
}
