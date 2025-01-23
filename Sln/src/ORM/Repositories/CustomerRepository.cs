using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(DefaultContext context) : base(context) { }
}
