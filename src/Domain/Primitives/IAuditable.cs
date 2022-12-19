namespace Domain.Primitives;

public interface IAuditable
{
    public string CreatedUser { get; set; }
    public string? UpdatedUser { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }

}