using System.Security.Cryptography;
using Domain.Primitives;

namespace Domain.Entities;

public class Season :Entity
{
    public string Name { get; set; } = string.Empty;
    public bool IsCurrent { get; set; } = false;
}