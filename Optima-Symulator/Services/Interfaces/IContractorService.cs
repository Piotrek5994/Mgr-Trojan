using Optima_Symulator.Models;

namespace Optima_Symulator.Services.Interfaces;

public interface IContractorService
{
    Task<List<Contractor>> GetContractorsAsync();
}
