using System.Linq.Expressions;
using Application.Interfaces;
using Application.Specifications;
using Domain.Primitives;
using Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : Entity
{
    private readonly AppDbContext _context;

    public GenericRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<T> FindByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }


    public IQueryable<T> FindFilter(Expression<Func<T?, bool>> filter)
    {
        return _context.Set<T>().Where(filter);
    }

    public IQueryable<T> FindFilterAsNoTracking(Expression<Func<T?, bool>> filter)
    {
        return _context.Set<T>().Where(filter).AsNoTracking();
    }

    public async Task<List<T>> ListFilterAsNoTrackingAsync(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().Where(filter).AsNoTracking().ToListAsync();
    }

    public async Task<List<T>> ListFilterAsync(Expression<Func<T, bool>> filter)
    {
        return await _context.Set<T>().Where(filter).ToListAsync();
    }

    public async Task<List<T>> ListAsNoTrackingAsync()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<List<T>> ListAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }


    public async Task AddAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _context.Set<T>().AddRangeAsync(entities);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }

    public void UpdateRange(IEnumerable<T> entities)
    {
        _context.Set<T>().UpdateRange(entities);
    }

    public async Task<IReadOnlyList<T>> ListFilterAsync(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).ToListAsync();
    }

    public async Task<int> CountAsync(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).CountAsync();
    }

    public async Task<T?> FindByIdAsync(ISpecification<T> spec)
    {
        return await ApplySpecification(spec).FirstOrDefaultAsync();
    }

    private IQueryable<T> ApplySpecification(ISpecification<T> spec)
    {
        return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
    }
}