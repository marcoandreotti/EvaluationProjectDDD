using Domain.Entities;
using Domain.Repositories.Common;

namespace Domain.Repositories;

/// <summary>
/// Repository interface for generic entity operations [Product]
/// </summary>
public interface IProductRepository : IRepository<Product> { }
