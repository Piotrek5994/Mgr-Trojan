using IdoBook_Symulator.Enums;

namespace IdoBook_Symulator.Models.Reservations;

public class Payment
{
    public int PaymentId { get; set; }  // Unique payment ID
    public decimal Amount { get; set; }  // Payment amount
    public PaymentMethod PaymentMethod { get; set; } // Payment method (e.g. card, transfer, cash)
    public DateTime PaymentDate { get; set; } // Payment date
}
