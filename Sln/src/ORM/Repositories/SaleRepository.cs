using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

/// <summary>
/// Implementation of Repository<Sale> and ISaleRepository using Entity Framework Core
/// </summary>
public class SaleRepository : Repository<Sale>, ISaleRepository
{
    /// <summary>
    /// Initializes a new instance of SaleRepository inherited from the generic repository
    /// </summary>
    /// <param name="context">The database context</param>
    public SaleRepository(DefaultContext context) : base(context) { }
}
