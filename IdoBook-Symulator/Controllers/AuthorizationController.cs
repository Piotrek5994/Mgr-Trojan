using IdoBook_Symulator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

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
