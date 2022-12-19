using System.Linq.Expressions;
using Domain.Primitives;

namespace Application.Interfaces;

public interface IGenericRepository<T> where T : Entity
{
    Task<T> FindByIdAsync(int id);


    IQueryable<T> FindFilter(Expression<Func<T?, bool>> filter);
    IQueryable<T> FindFilterAsNoTracking(Expression<Func<T?, bool>> filter);


    Task<List<T>> ListFilterAsNoTrackingAsync(Expression<Func<T, bool>> filter);
    Task<List<T>> ListFilterAsync(Expression<Func<T, bool>> filter);
    Task<List<T>> ListAsNoTrackingAsync();
    Task<List<T>> ListAsync();

    Task AddAsync(T entity);
    Task AddRangeAsync(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    void Update(T entity);
    void UpdateRange(IEnumerable<T> entities);


    Task<IReadOnlyList<T>> ListFilterAsync(ISpecification<T> spec);
    Task<int> CountAsync(ISpecification<T> spec);
    Task<T?> FindByIdAsync(ISpecification<T> spec);
}