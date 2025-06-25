using IdoBook_Symulator.Models.Client;
using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

public class ClientController : BaseController
{
    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClientInformation))]
    public async Task<IActionResult> GetClientAsync([FromQuery] int clientId)
    {
        return Ok();
    }
}
