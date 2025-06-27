using Optima_Symulator.Enums;

namespace Optima_Symulator.Models;

public class Document
{
    public string NumerDokumentu { get; set; } = string.Empty; // Document number
    public DateTime DataWystawienia { get; set; } // Date of document issue
    public decimal KwotaNetto { get; set; } // Net amount
    public decimal KwotaBrutto { get; set; } // Gross amount
    public Contractor Kontrahent { get; set; } = new(); // Contractor (connection with contractor)
    public TypDokumentu TypDokumentu { get; set; } // Document type (FS, FZ, PA)
    public decimal Status { get; set; } // Document status as decimal (e.g. 1.0 - completed, 0.0 - pending)
    public Vat Vat { get; set; } // VAT type
}
