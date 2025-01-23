using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

public class SaleItemRepository : Repository<SaleItem>, ISaleItemRepository
{
    public SaleItemRepository(DefaultContext context) : base(context) { }
}
