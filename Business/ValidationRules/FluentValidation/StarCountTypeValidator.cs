using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StarCountTypeValidator : AbstractValidator<StarCountType>
    {
        public StarCountTypeValidator()
        {
            RuleFor(s => s.Name).NotEmpty();
            RuleFor(s => s.Name).MinimumLength(1);
            RuleFor(s => s.Name).MaximumLength(30);
        }
    }
}
