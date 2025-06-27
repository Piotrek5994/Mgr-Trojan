using IdoBook_Symulator.Models.Reservations;
using IdoBook_Symulator.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdoBook_Symulator.Controllers;

[Authorize]
public class ReservationsController : BaseController
{
    private readonly IReservationsService _reservationsService;

    public ReservationsController(IReservationsService reservationsService)
    {
        _reservationsService = reservationsService;
    }

    [HttpGet]
    [Route("Get")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Reservation))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public async Task<IActionResult> GetReservationsAsync([FromQuery] int? reservationId)
    {
        if(reservationId <= 0 && reservationId is not null)
            return BadRequest("Reservation ID must be greater than zero.");

        var reservations = _reservationsService.GetReservations(reservationId);

        if (reservations == null || !reservations.Any())
            return NotFound("No reservations found.");

        return Ok(reservations);
    }
}
