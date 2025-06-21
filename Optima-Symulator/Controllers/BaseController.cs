using Microsoft.AspNetCore.Mvc;

namespace Optima_Symulator.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{
    [NonAction]
    protected string GetNotFoundMessage(string methodName)
        => $"No data found while executing {methodName}";

    [NonAction]
    protected string GetBadRequestMessage(string methodName)
        => $"Error during execution {methodName}";
}
