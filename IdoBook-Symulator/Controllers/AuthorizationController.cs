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

    /// <summary>
    /// Generates a JWT token for a given login and password.
    /// </summary>
    [HttpPost("Get")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TokenResponse))]
    [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(ErrorResponse))]
    public IActionResult GetToken([FromQuery] string login,string password)
    {
        try
        {
            var token = _authorizationService.GenerateToken(login, password);
            return Ok(new TokenResponse { Token = token });
        }
        catch (UnauthorizedAccessException)
        {
            return Unauthorized(new ErrorResponse { Error = GetUnauthorizedMessage(nameof(GetToken)) });
        }
    }

    /// <summary>
    /// Refreshes a JWT token if it's still valid.
    /// </summary>
    [HttpPut("Refres")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(TokenResponse))]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorResponse))]
    public IActionResult RefresToken([FromQuery] string token)
    {
        try
        {
            var newToken = _authorizationService.RefreshToken(token);
            return Ok(new TokenResponse { Token = newToken });
        }
        catch (Exception)
        {
            return BadRequest(new ErrorResponse { Error = GetBadRequestMessage(nameof(RefresToken)) });
        }
    }
}
