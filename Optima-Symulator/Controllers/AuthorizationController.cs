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
    public async Task<IActionResult> GetToken()
    {
        return Ok();
    }
    [HttpPut]
    public async Task<IActionResult> RefresToken()
    {
        return Ok();
    }
}
