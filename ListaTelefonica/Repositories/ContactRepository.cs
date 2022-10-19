using Blazored.LocalStorage;
using ListaTelefonica.Interfaces;
using ListaTelefonica.Models;

namespace ListaTelefonica.Repositories;

public class ContactRepository : IContactRepository
{
    private readonly ILocalStorageService _localStorage;

    private const string _keyContacts = "Contacts";

    public ContactRepository(ILocalStorageService localStorage)
    {
        _localStorage = localStorage;
    }

    public async Task<List<ContactInfo>> GetAllAsync()
    {
        return await _localStorage.GetItemAsync<List<ContactInfo>>(_keyContacts);
    }

    public async Task<ContactInfo> GetAsync(Guid id)
    {
        var contacts = await _localStorage.GetItemAsync<List<ContactInfo>>(_keyContacts);
        return contacts.FirstOrDefault(x => x.Id == id);
    }
}
