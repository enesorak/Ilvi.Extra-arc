using Domain.Primitives;

namespace Domain.Entities;

public class Entry : Entity
{
    public EntryType EntryType { get; set; }
    public int EntryTypeId { get; set; }
    public Account Account { get; set; }
    public int AccountId { get; set; }

    // Total installment that arranged btw companies
    public int Installment { get; set; }

    public DateOnly DueDate { get; set; }
    
    public decimal Estimated { get; set; }
    public decimal Actual { get; set; }
    
    
    public string? Season { get; set; }
    public string? OrderNumber { get; set; }
    public string? InvoiceNumber { get; set; }
    
    public bool Confirmed { get; set; }
    public DateTime ConfirmationDate { get; set; }
    public string? ConfirmedUser { get; set; }

    public bool Recurring { get; set; }

    public bool Completed { get; set; }
    
}