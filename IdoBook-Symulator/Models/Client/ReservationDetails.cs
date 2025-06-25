using IdoBook_Symulator.Enums;

namespace IdoBook_Symulator.Models.Client;

public class ReservationDetails
{
    public int ReservationId { get; set; }
    public DateTime CheckInDate { get; set; } 
    public DateTime CheckOutDate { get; set; }
    public decimal TotalAmount { get; set; }
    public RoomType RoomType { get; set; }
}
