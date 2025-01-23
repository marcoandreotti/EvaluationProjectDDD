using Domain.Entities;
using Domain.Repositories.Common;

namespace Domain.Repositories;

/// <summary>
/// Repository interface for generic entity operations [User]
/// </summary>
public interface IUserRepository : IRepository<User>
{
    /// <summary>
    /// [Specialization] - Retrieves a user by their email address
    /// </summary>
    /// <param name="email">The email address to search for</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The user if found, null otherwise</returns>
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
}
