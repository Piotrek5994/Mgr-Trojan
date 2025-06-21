using Microsoft.AspNetCore.Mvc;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorizationController : ControllerBase
{
    private readonly IAuthorizationService _authorizationService;

    public AuthorizationController(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }
}
