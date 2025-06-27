using IdoBook_Symulator.Enums;
using IdoBook_Symulator.Models.Reservations;
using IdoBook_Symulator.Services.Interfaces;

namespace IdoBook_Symulator.Services;

public class ReservationsService : IReservationsService
{
    private List<Reservation> _reservations = new List<Reservation>
        {
            new Reservation
            {
                ReservationId = 1,
                ReservationDate = DateTime.Now.AddDays(-1),
                CheckInDate = DateTime.Now.AddDays(1),
                CheckOutDate = DateTime.Now.AddDays(3),
                Room = new Room
                {
                    RoomId = 1,
                    RoomType = RoomType.Single,
                    Floor = 1,
                    PricePerNight = 100m,
                    IsAvailable = true
                },
                Client = new Client
                {
                    ClientId = 1,
                    Username = "jan.kowalski",
                    Name = "Jan Kowalski",
                    Email = "jan.kowalski@example.com",
                    Phone = "+48 123 456 789"
                },
                Payment = new Payment
                {
                    PaymentId = 1,
                    Amount = 300m,
                    PaymentMethod = PaymentMethod.Card,
                    PaymentDate = DateTime.Now.AddDays(-1)
                },
                Status = ReservationStatus.Confirmed
            },
            new Reservation
            {
                ReservationId = 2,
                ReservationDate = DateTime.Now.AddDays(-2),
                CheckInDate = DateTime.Now.AddDays(2),
                CheckOutDate = DateTime.Now.AddDays(4),
                Room = new Room
                {
                    RoomId = 2,
                    RoomType = RoomType.Double,
                    Floor = 1,
                    PricePerNight = 150m,
                    IsAvailable = true
                },
                Client = new Client
                {
                    ClientId = 2,
                    Username = "anna.nowak",
                    Name = "Anna Nowak",
                    Email = "anna.nowak@example.com",
                    Phone = "+48 234 567 890"
                },
                Payment = new Payment
                {
                    PaymentId = 2,
                    Amount = 400m,
                    PaymentMethod = PaymentMethod.Cash,
                    PaymentDate = DateTime.Now.AddDays(-2)
                },
                Status = ReservationStatus.Confirmed
            },
            new Reservation
            {
                ReservationId = 3,
                ReservationDate = DateTime.Now.AddDays(-3),
                CheckInDate = DateTime.Now.AddDays(3),
                CheckOutDate = DateTime.Now.AddDays(5),
                Room = new Room
                {
                    RoomId = 3,
                    RoomType = RoomType.Suite,
                    Floor = 2,
                    PricePerNight = 200m,
                    IsAvailable = true
                },
                Client = new Client
                {
                    ClientId = 3,
                    Username = "piotr.zielinski",
                    Name = "Piotr Zieliński",
                    Email = "piotr.zielinski@example.com",
                    Phone = "+48 345 678 901"
                },
                Payment = new Payment
                {
                    PaymentId = 3,
                    Amount = 350m,
                    PaymentMethod = PaymentMethod.Transfer,
                    PaymentDate = DateTime.Now.AddDays(-3)
                },
                Status = ReservationStatus.Confirmed
            }
        };

    public List<Reservation> GetReservations(int? reservationId)
    {
        if (reservationId.HasValue)
        {
            return _reservations.Where(r => r.ReservationId == reservationId.Value).ToList();
        }
        return _reservations;
    }
}
