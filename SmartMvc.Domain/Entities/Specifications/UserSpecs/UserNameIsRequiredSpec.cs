using SmartMvc.Domain.Interfaces.Specification;

namespace SmartMvc.Domain.Entities.Specifications.UserSpecs
{
    public class UserNameIsRequiredSpec : ISpecification<User>
    {
        public bool IsSatisfiedBy(User user)
        {
            return user.Name.Length > 0;
        }
    }
}
