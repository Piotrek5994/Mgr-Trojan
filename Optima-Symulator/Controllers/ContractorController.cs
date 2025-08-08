using Microsoft.AspNetCore.Mvc;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Controllers;

public class ContractorController : BaseController
{
    private readonly IContractorService _contractorService;

    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetContractorAsync()
    {
        var result = await _contractorService.GetContractorsAsync();

        if (result == null || !result.Any())
        {
            return NotFound(new { Message = "No contractors found." });
        }

        return Ok(result);
    }

    [HttpPost]
    [Route("Create")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateContractorAsync()
    {
        return Ok();
    }
}
