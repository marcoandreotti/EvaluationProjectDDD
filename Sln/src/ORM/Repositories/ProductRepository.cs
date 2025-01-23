using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(DefaultContext context) : base(context) { }
}