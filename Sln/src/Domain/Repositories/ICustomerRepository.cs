using Domain.Entities;
using Domain.Repositories.Common;

namespace Domain.Repositories;

/// <summary>
/// Repository interface for generic entity operations [Customer]
/// </summary>
public interface ICustomerRepository : IRepository<Customer> { }
