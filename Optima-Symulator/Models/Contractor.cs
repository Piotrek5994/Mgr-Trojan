namespace Optima_Symulator.Models;

public class Contractor
{
    public string Akronim { get; set; } = string.Empty; // Abbreviation of the contractor's name
    public string NazwaFirmy { get; set; } = string.Empty; // Contractor's company name
    public string NIP { get; set; } = string.Empty;  // Contractor's Tax Identification Number
    public string Adres { get; set; } = string.Empty;  // Contractor's registered office address
    public string Email { get; set; } = string.Empty; // Customer's email (optional)
    public string Telefon { get; set; } = string.Empty; // Customer's phone number (optional)
}
