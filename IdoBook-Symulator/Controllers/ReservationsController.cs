using IdoBook_Symulator.Models.Reservations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

[Authorize]
public class ReservationsController : BaseController
{
    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Reservation))]
    public async Task<IActionResult> GetReservationsAsync()
    {
        return Ok();
    }
}
