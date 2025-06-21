using IdoBook_Symulator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

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
