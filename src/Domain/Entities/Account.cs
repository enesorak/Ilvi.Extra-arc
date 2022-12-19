using Domain.Primitives;

namespace Domain.Entities;

public class Account :Entity
{
    public string Name { get; set; }

    public AccountGroup AccountGroup { get; set; }
    public int AccountGroupId { get; set; }
    
    public string? IBAN { get; set; }
    public string? TaxOffice { get; set; }
    public string? TaxNumber { get; set; }
    
}