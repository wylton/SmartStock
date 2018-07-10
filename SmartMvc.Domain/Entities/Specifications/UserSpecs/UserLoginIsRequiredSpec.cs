using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.UserSpecs
{
    public class UserLoginIsRequiredSpec : ISpecification<User>
    {
        public bool IsSatisfiedBy(User user)
        {
            return user.Login.Length > 0;
        }
    }
}
