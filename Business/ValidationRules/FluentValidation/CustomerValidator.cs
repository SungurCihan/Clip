using Business.Constants;
using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).MinimumLength(2);
            RuleFor(c => c.LastName).MinimumLength(2);
            RuleFor(c => c.Email).EmailAddress();
            RuleFor(c => c.Password).MinimumLength(8);
            RuleFor(c => c.Password).Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$").WithMessage(Messages.PasswordValidation);
        }
    }
}
