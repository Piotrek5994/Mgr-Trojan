using Microsoft.AspNetCore.Mvc;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Controllers;

public class AuthorizationController : BaseController
{
    private readonly IAuthorizationService _authorizationService;

    public AuthorizationController(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }

    [HttpPost]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetToken()
    {
        return Ok();
    }
    [HttpPut]
    [Route("Refres")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> RefresToken(string token)
    {
        return Ok();
    }
}
