using Optima_Symulator.Enums;
using Optima_Symulator.Models;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Services;

public class DocumentService : IDocumentService
{
    private readonly List<Document> _documents;

    public DocumentService()
    {
        _documents =
            [
                new ()
                {
                    NumerDokumentu = "FS/001/2025",
                    DataWystawienia = DateTime.Now.AddDays(-10),
                    KwotaNetto = 1000m,
                    KwotaBrutto = 1230m,
                    Kontrahent = new Contractor
                    {
                        Akronim = "ABC",
                        NazwaFirmy = "ABC Sp. z o.o.",
                        NIP = "1234567890",
                        Adres = "ul. Przykładowa 1, 00-000 Warszawa",
                        Email = "kontakt@abc.pl",
                        Telefon = "123-456-789"
                    },
                    TypDokumentu = TypDokumentu.FS,
                    Status = 1.0m,
                    Vat = Vat.VAT8
                },
                new ()
                {
                    NumerDokumentu = "FZ/002/2025",
                    DataWystawienia = DateTime.Now.AddDays(-5),
                    KwotaNetto = 500m,
                    KwotaBrutto = 615m,
                    Kontrahent = new Contractor
                    {
                        Akronim = "XYZ",
                        NazwaFirmy = "XYZ S.A.",
                        NIP = "0987654321",
                        Adres = "ul. Inna 5, 00-001 Kraków",
                        Email = "biuro@xyz.pl",
                        Telefon = "987-654-321"
                    },
                    TypDokumentu = TypDokumentu.FZ,
                    Status = 0.0m,
                    Vat = Vat.VAT5
                }
            ];
    }

    public Task<List<Document>> GetDocumentsAsync()
    {
        return Task.FromResult(_documents);
    }
}
