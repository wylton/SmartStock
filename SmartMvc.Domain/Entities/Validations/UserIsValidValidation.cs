using SmartMvc.Domain.Entities.Specifications.UserSpecs;
using SmartMvc.Domain.Validation;

namespace SmartMvc.Domain.Entities.Validations
{
    public class UserIsValidValidation : Validation<User>
    {
        public UserIsValidValidation()
        {
            base.AddRule(new ValidationRule<User>(new UserNameIsRequiredSpec(), ValidationMessages.UserNameIsRequired));
            base.AddRule(new ValidationRule<User>(new UserLoginIsRequiredSpec(), ValidationMessages.UserLoginIsRequired));
            base.AddRule(new ValidationRule<User>(new UserPasswordIsRequiredSpec(), ValidationMessages.UserPasswordIsRequired));
        }
    }
}
