using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class StarCountValidator : AbstractValidator<StarCount>
    {
        public StarCountValidator()
        {
            RuleFor(s => s.Star).NotEmpty();
            RuleFor(s => s.Star).LessThanOrEqualTo(5);
            RuleFor(s => s.Star).GreaterThanOrEqualTo(0);
        }
    }
}
