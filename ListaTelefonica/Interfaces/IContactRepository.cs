namespace ListaTelefonica.Interfaces;
using ListaTelefonica.Models;

public interface IContactRepository
{
    Task<List<ContactInfo>> GetAllAsync();
    Task<ContactInfo> GetAsync(Guid id);
}
