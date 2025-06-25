using IdoBook_Symulator.Enums;

namespace IdoBook_Symulator.Models.Reservations;

public class Reservation
{
    public int ReservationId { get; set; }  // Unique booking identifier
    public DateTime ReservationDate { get; set; } // Booking date
    public DateTime CheckInDate { get; set; }  // Check-in date
    public DateTime CheckOutDate { get; set; } // Check-out date
    public Room Room { get; set; } = new(); // Room assigned to the reservation
    public Client Client { get; set; } = new(); // Customer who made the reservation
    public Payment Payment { get; set; } = new(); // Payment related to reservation
    public ReservationStatus Status { get; set; } // Reservation status (e.g. 'Confirmed', 'Pending', 'Cancelled')
}
