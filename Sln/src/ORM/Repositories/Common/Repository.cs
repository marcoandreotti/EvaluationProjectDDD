using Domain.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace ORM.Repositories.Common;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly DbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    /// <summary>
    /// Retrieves a ENTITY by their unique identifier
    /// </summary>
    /// <param name="id">The unique identifier</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The ENTITY if found, null otherwise</returns>
    public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken = default) => await _dbSet.FindAsync(id, cancellationToken);

    /// <summary>
    /// Retrieves all ENTITIES
    /// </summary>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The ENTITIES list if found, null otherwise</returns>
    public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default) => await _dbSet.ToListAsync();

    /// <summary>
    /// Creates/Add a new ENTITY in the repository
    /// </summary>
    /// <param name="entity">ENTITY</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created ENTITY</returns>
    public async Task<T> AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        await _dbSet.AddAsync(entity, cancellationToken);
        await _context.SaveChangesAsync();

        return entity;
    }

    /// <summary>
    /// Update a ENTITY in the repository
    /// </summary>
    /// <param name="entity">ENTITY</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The modified ENTITY</returns>
    public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return entity;
    }

    /// <summary>
    /// Deletes a ENTITY from the repository
    /// </summary>
    /// <param name="id">The unique identifier of the ENTITY to delete</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>True if the ENTITY was deleted, false if not found</returns>
    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await GetByIdAsync(id, cancellationToken);
        if (entity != null)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();

            return true;
        }
        return false;
    }
}
