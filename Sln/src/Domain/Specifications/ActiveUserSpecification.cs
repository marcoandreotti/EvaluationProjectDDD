using Domain.Entities;
using Domain.Enums;

namespace Domain.Specifications;

public class ActiveUserSpecification : ISpecification<User>
{
    public bool IsSatisfiedBy(User user)
    {
        return user.Status == UserStatus.Active;
    }
}
