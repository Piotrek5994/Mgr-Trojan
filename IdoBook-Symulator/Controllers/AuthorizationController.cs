using IdoBook_Symulator.Services.Interfaces;

namespace IdoBook_Symulator.Controllers;

public class AuthorizationController : BaseController
{
    private readonly IAuthorizationService _authorizationService;

    public AuthorizationController(IAuthorizationService authorizationService)
    {
        _authorizationService = authorizationService;
    }
}
