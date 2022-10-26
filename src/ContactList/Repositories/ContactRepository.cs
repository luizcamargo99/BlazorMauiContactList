using Blazored.LocalStorage;
using ContactList.Interfaces;
using ContactList.Models;

namespace ContactList.Repositories;

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
        var contacts = await GetAllAsync();
        return contacts.FirstOrDefault(x => x.Id == id);
    }

    public async Task<bool> Save(ContactInfo model)
    {
        var isSuccess = true;

        try
        {
            var contacts = await GetAllAsync() ?? new List<ContactInfo>();

            if (model.Id is null)
            {
                model.Id = Guid.NewGuid();
            }
            else
            {
                contacts.RemoveAll(x => x.Id == model.Id);
            }

            contacts.Add(model);

            await _localStorage.SetItemAsync(_keyContacts, contacts);
        }
        catch
        {
            isSuccess = false;
        }

        return isSuccess;
    }

    public async Task<bool> Delete(Guid id)
    {
        var isSuccess = true;

        try
        {
            var contacts = await GetAllAsync() ?? new List<ContactInfo>();

            contacts.RemoveAll(x => x.Id == id);

            await _localStorage.SetItemAsync(_keyContacts, contacts);
        }
        catch
        {
            isSuccess = false;
        }

        return isSuccess;
    }

}
