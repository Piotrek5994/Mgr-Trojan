using IdoBook_Symulator.Models.Reservations;

namespace IdoBook_Symulator.Services.Interfaces;

public interface IReservationsService
{
    List<Reservation> GetReservations(int? reservationId);
}
