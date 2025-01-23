using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

/// <summary>
/// Implementation of Repository<Branch> and IBranchRepository using Entity Framework Core
/// </summary>
public class BranchRepository : Repository<Branch>, IBranchRepository
{
    /// <summary>
    /// Initializes a new instance of BranchRepository inherited from the generic repository
    /// </summary>
    /// <param name="context">The database context</param>
    public BranchRepository(DefaultContext context) : base(context) { }
}
