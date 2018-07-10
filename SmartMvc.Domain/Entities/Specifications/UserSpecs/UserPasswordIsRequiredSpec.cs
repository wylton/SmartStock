using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.UserSpecs
{
    public class UserPasswordIsRequiredSpec : ISpecification<User>
    {
        public bool IsSatisfiedBy(User user)
        {
            return user.Password.Length > 0;
        }
    }
}
