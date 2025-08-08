using Optima_Symulator.Models;

namespace Optima_Symulator.Services.Interfaces;

public interface IDocumentService
{
    Task<List<Document>> GetDocumentsAsync();
}
