using IdoBook_Symulator.Models.Client;

namespace IdoBook_Symulator.Services.Interfaces;

public interface IClientService
{
    List<ClientInformation> GetClients(int? clientId);
}
