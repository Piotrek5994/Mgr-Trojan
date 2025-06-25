using IdoBook_Symulator.Models.Client;
using IdoBook_Symulator.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

public class ClientController : BaseController
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ClientInformation))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetClientAsync([FromQuery] int clientId)
    {
        if (clientId <= 0)
            return BadRequest("clientId must be greater than zero.");

        var client = _clientService.GetClients(clientId);

        if (!client.Any())
            return NotFound($"Client with ID {clientId} not found.");

        return Ok(client);
    }
}
