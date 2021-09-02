using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeStarCountValidator : AbstractValidator<EmployeeStarCount>
    {
        public EmployeeStarCountValidator()
        {
            RuleFor(e => e.StarCount).NotEmpty();
            RuleFor(e => e.StarCount).GreaterThanOrEqualTo(0);
            RuleFor(e => e.StarCount).LessThanOrEqualTo(5);
        }
    }
}
