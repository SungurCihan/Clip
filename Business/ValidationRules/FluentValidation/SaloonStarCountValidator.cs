using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SaloonStarCountValidator : AbstractValidator<SaloonStarCount>
    {
        public SaloonStarCountValidator()
        {
            RuleFor(s => s.StarCount).NotEmpty();
            RuleFor(s => s.StarCount).GreaterThanOrEqualTo(0);
            RuleFor(s => s.StarCount).LessThanOrEqualTo(5);
        }
    }
}
