using IdoBook_Symulator.Enums;
using IdoBook_Symulator.Models.Client;
using IdoBook_Symulator.Services.Interfaces;

namespace IdoBook_Symulator.Services;

public class ClientService : IClientService
{
    public List<ClientInformation> GetClients(int? clientId)
    {
        if (clientId.HasValue && clientId.Value != 0)
            return _sampleClients.Where(client => client.ClientId == clientId.Value).ToList();

        return _sampleClients;
    }

    private List<ClientInformation> _sampleClients = new List<ClientInformation>
    {
            new ()
            {
                ClientId = 1,
                FullName = "Jan Kowalski",
                Email = "jan.kowalski@example.com",
                PhoneNumber = "+48 123 456 789",
                Address = "ul. Przykładowa 10, 00-000 Warszawa",
                TaxId = "PL1234567890",
                LastPaymentDate = DateTime.Now.AddDays(-10),
                Reservations = new List<ReservationDetails>
                {
                    new ()
                    {
                        ReservationId = 1,
                        CheckInDate = DateTime.Now.AddDays(1),
                        CheckOutDate = DateTime.Now.AddDays(3),
                        TotalAmount = 300m,
                        RoomType = RoomType.Single
                    }
                }
            },
            new ()
            {
                ClientId = 2,
                FullName = "Anna Nowak",
                Email = "anna.nowak@example.com",
                PhoneNumber = "+48 234 567 890",
                Address = "ul. Wzorcowa 5, 00-001 Warszawa",
                TaxId = "PL9876543210",
                LastPaymentDate = DateTime.Now.AddDays(-20),
                Reservations = new List<ReservationDetails>
                {
                    new ()
                    {
                        ReservationId = 2,
                        CheckInDate = DateTime.Now.AddDays(2),
                        CheckOutDate = DateTime.Now.AddDays(4),
                        TotalAmount = 400m,
                        RoomType = RoomType.Double
                    }
                }
            },
            new ()
            {
                ClientId = 3,
                FullName = "Piotr Zieliński",
                Email = "piotr.zielinski@example.com",
                PhoneNumber = "+48 345 678 901",
                Address = "ul. Nowa 8, 01-234 Kraków",
                TaxId = "PL1122334455",
                LastPaymentDate = DateTime.Now.AddDays(-30),
                Reservations = new List<ReservationDetails>
                {
                    new ()
                    {
                        ReservationId = 3,
                        CheckInDate = DateTime.Now.AddDays(3),
                        CheckOutDate = DateTime.Now.AddDays(5),
                        TotalAmount = 350m,
                        RoomType = RoomType.Suite
                    }
                }
            }
    };
}
