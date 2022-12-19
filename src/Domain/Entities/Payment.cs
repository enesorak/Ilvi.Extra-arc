using Domain.Primitives;

namespace Domain.Entities;

public class Payment :Entity
{
    public Entry Entry { get; set; }
    public int EntryId { get; set; }

    public int InstallmentOrder { get; set; }
    
    public decimal Estimated { get; set; }
    public decimal Actual { get; set; }

    public bool Locked { get; set; }
    public bool Paid { get; set; }
    public bool Reserved { get; set; }
    
}