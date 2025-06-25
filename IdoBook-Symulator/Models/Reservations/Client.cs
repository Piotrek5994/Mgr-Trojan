namespace IdoBook_Symulator.Models.Reservations;

public class Client
{
    public int ClientId { get; set; } // Unique client identifier
    public string Username { get; set; } = string.Empty; // Client username
    public string Name { get; set; } = string.Empty; // Customer name
    public string Email { get; set; } = string.Empty; // Customer email
    public string Phone { get; set; } = string.Empty; // Customer's phone number
}
