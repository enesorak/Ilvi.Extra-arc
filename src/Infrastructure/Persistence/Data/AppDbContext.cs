using System.Reflection;
using Domain.Entities;
using Infrastructure.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;
using DateOnlyConverter = Infrastructure.Persistence.Configuration.DateOnlyConverter;

namespace Infrastructure.Persistence.Data;

public class AppDbContext : DbContext
{
    private const string connectionString =
        "Server=localhost;Database=Ilviextra;User Id=sa;Password=Password123; Trusted_Connection=false;TrustServerCertificate=True;MultipleActiveResultSets=true";


    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Entry> Entries { get; set; }
    public DbSet<EntryType> EntryTypes { get; set; }
    public DbSet<Payment> Payments { get; set; }
   

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<DateOnly>().HaveConversion<DateOnlyConverter>().HaveColumnType("date");
        base.ConfigureConventions(configurationBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder
                .EnableSensitiveDataLogging()
                .UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Turkish_CI_AS");
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.Seed();
    }
}