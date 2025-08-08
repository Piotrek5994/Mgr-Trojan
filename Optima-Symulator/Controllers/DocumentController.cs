using Microsoft.AspNetCore.Mvc;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Controllers;

public class DocumentController : BaseController
{
    private readonly IDocumentService _documentService;

    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetContractorAsync()
    {
        var result = await _documentService.GetDocumentsAsync();

        if (result == null || !result.Any())
        {
            return NotFound(new { Message = "No documents found." });
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
