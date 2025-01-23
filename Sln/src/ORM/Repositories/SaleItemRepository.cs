using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

/// <summary>
/// Implementation of Repository<SaleItem> and ISaleItemRepository using Entity Framework Core
/// </summary>
public class SaleItemRepository : Repository<SaleItem>, ISaleItemRepository
{
    /// <summary>
    /// Initializes a new instance of SaleItemRepository inherited from the generic repository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleItemRepository(DefaultContext context) : base(context) { }
}
