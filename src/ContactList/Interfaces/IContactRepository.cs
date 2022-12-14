namespace ContactList.Interfaces;
using ContactList.Models;

public interface IContactRepository
{
    Task<List<ContactInfo>> GetAllAsync();
    Task<ContactInfo> GetAsync(Guid id);
    Task<bool> Save(ContactInfo model);
    Task<bool> Delete(Guid id);
}
