using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            //ServiceName
            RuleFor(s => s.ServiceName).NotEmpty();
            RuleFor(s => s.ServiceName).MinimumLength(1);
            RuleFor(s => s.ServiceName).MaximumLength(50);

            //ServicePrice
            RuleFor(s => s.ServicePrice).NotEmpty();
            RuleFor(s => s.ServicePrice).GreaterThanOrEqualTo(10);
            RuleFor(s => s.ServicePrice).LessThanOrEqualTo(5000);
        }
    }
}
