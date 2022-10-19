using ListaTelefonica.Enums;

namespace ListaTelefonica.Models;

public class ContactInfo
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateOnly BirthDate { get; set; }
    public EContactPriorization Priorization { get; set; }
}
