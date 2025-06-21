using Microsoft.AspNetCore.Mvc;

namespace Optima_Symulator.Controllers;

public class ContractorController : BaseController
{
    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetContractorAsync()
    {
        return Ok();
    }

    [HttpPost]
    [Route("Create")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateContractorAsync()
    {
        return Ok();
    }
}
