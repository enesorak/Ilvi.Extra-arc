using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configuration;

public class EstimationsConfiguration :IEntityTypeConfiguration<Estimation>
{
    public void Configure(EntityTypeBuilder<Estimation> builder)
    {
        builder.Property(p=> p.Amount).HasColumnType("decimal").HasPrecision(18, 4);
    }
}