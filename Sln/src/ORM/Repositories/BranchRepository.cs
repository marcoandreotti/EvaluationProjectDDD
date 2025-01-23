using Domain.Entities;
using Domain.Repositories;
using ORM.Repositories.Common;

namespace ORM.Repositories;

public class BranchRepository : Repository<Branch>, IBranchRepository
{
    public BranchRepository(DefaultContext context) : base(context) { }
}
