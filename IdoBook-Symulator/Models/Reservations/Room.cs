using IdoBook_Symulator.Enums;

namespace IdoBook_Symulator.Models.Reservations;

public class Room
{
    public int RoomId { get; set; } // Unique room identifier
    public RoomType RoomType { get; set; } // Room type (e.g. 'Single', 'Double', 'Suite')
    public int Floor { get; set; }  // Floor where the room is located
    public decimal PricePerNight { get; set; } // Price per night
    public bool IsAvailable { get; set; } // Room Availability Status
}
