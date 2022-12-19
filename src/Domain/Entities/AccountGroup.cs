using Domain.Primitives;

namespace Domain.Entities;

public class AccountGroup :Entity   
{
    public string Name { get; set; }
    public int Parent { get; set; }
}