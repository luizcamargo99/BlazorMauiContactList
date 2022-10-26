using ContactList.Enums;

namespace ContactList.Models;

public class ContactInfo
{
    public Guid? Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public EContactPriorization Priorization { get; set; }
}
