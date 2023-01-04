using System.ComponentModel.DataAnnotations.Schema;
using Domain.Primitives;

namespace Domain.Entities;

public class Estimation :Entity
{
    public Entry Entry { get; set; }
    public int EntryId { get; set; }
    public decimal Amount { get; set; }
    public bool IsExpired { get; set; }
    public DateTime ExpireAt { get; set; }

    public string? Application { get; set; }
 
}