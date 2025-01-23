using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

/// <summary>
/// Implementation of Repository<Customer> and ICustomerRepository using Entity Framework Core
/// </summary>
public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    /// <summary>
    /// Initializes a new instance of CustomerRepository inherited from the generic repository
    /// </summary>
    /// <param name="context">The database context</param>
    public CustomerRepository(DefaultContext context) : base(context) { }
}
