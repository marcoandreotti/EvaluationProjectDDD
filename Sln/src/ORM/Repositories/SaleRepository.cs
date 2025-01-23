using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

public class SaleRepository : Repository<Sale>, ISaleRepository
{
    public SaleRepository(DefaultContext context) : base(context) { }
}
