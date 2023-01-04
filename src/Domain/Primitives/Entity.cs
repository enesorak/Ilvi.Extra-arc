namespace Domain.Primitives;

public abstract class Entity: IAuditable, IBlock
{
    public int Id { get; set; }
    public string SourceId { get; set; } = string.Empty;
    public string CreatedUser { get; set; }
    public string? UpdatedUser { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    public bool Blocked { get; set; } = false;
}