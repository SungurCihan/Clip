using Business.Constants;
using Core.Entities.Concrete;
using Entity.DTO_s;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserValidator()
        {
            RuleFor(u => u.Password).Matches(@"((?=.*\d)(?=.*[a-z]){8,15})").WithMessage(Messages.PasswordValidation);
            RuleFor(u => u.Password).MinimumLength(8);
        }
    }
}
