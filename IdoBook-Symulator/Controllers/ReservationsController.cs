using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

public class ReservationsController : BaseController
{
    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetReservationsAsync()
    {
        return Ok();
    }
}
