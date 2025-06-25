namespace IdoBook_Symulator.Models.Client;

public class ClientInformation
{
    public int ClientId { get; set; }  // Unique client identifier
    public string FullName { get; set; } // Full name
    public string Email { get; set; } // Customer email
    public string PhoneNumber { get; set; } // Customer's phone number
    public string Address { get; set; } // Invoice shipping address
    public string TaxId { get; set; } // NIP or other tax identifier
    public DateTime LastPaymentDate { get; set; } // Last payment date
    public List<ReservationDetails> Reservations { get; set; } = new();
}
