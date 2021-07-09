using ContactsCL.Application.Filters;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ManageExceptionFilter))]
    public class BaseController : ControllerBase
    {
    }
}
