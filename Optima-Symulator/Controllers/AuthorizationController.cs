using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Controllers;

public class AuthorizationController : BaseController
{
    private readonly IAuthorizationService _authorizationService;

    public AuthorizationController(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }
}
