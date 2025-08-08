using Optima_Symulator.Models;
using Optima_Symulator.Services.Interfaces;

namespace Optima_Symulator.Services
{
    public class ContractorService : IContractorService
    {
        private readonly List<Contractor> _contractors;

        public ContractorService()
        {
            _contractors =
            [
                new ()
                {
                    Akronim = "ABC",
                    NazwaFirmy = "ABC Sp. z o.o.",
                    NIP = "1234567890",
                    Adres = "ul. Przykładowa 1, 00-000 Warszawa",
                    Email = "kontakt@abc.pl",
                    Telefon = "123-456-789"
                },
                new ()
                {
                    Akronim = "XYZ",
                    NazwaFirmy = "XYZ S.A.",
                    NIP = "0987654321",
                    Adres = "ul. Inna 5, 00-001 Kraków",
                    Email = "biuro@xyz.pl",
                    Telefon = "987-654-321"
                }
            ];
        }

        public Task<List<Contractor>> GetContractorsAsync()
        {
            return Task.FromResult(_contractors);
        }
    }
}
