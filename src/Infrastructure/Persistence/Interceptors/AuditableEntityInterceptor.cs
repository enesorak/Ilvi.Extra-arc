using Domain.Primitives;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Persistence.Interceptors;

public class AuditableEntityInterceptor : SaveChangesInterceptor
{
    public override ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData,
        InterceptionResult<int> result,
        CancellationToken cancellationToken = new())
    {
        var dbContext = eventData.Context;
        if (dbContext is null) return base.SavingChangesAsync(eventData, result, cancellationToken);

        var entries = dbContext.ChangeTracker.Entries<IAuditable>();
        try
        {
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added) entry.Property(x => x.CreatedDate).CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified) entry.Property(x => x.UpdatedDate).CurrentValue = DateTime.Now;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }


        return base.SavingChangesAsync(eventData, result, cancellationToken);
    }
}