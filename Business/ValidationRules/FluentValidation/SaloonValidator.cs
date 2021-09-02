using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SaloonValidator : AbstractValidator<Saloon>
    {
        public SaloonValidator()
        {
            //SaloonName
            RuleFor(s => s.SaloonName).NotEmpty();
            RuleFor(s => s.SaloonName).MinimumLength(1);
            RuleFor(s => s.SaloonName).MaximumLength(50);

            //Adress
            RuleFor(s => s.Addresss).NotEmpty();
            RuleFor(s => s.Addresss).MinimumLength(1);
            RuleFor(s => s.Addresss).MaximumLength(100);

            //PhoneNumber
            RuleFor(s => s.PhoneNumber).NotEmpty();
            RuleFor(s => s.PhoneNumber).Length(11);

            //Description
            RuleFor(s => s.Description).NotEmpty();
            RuleFor(s => s.Description).MinimumLength(1);
            RuleFor(s => s.Description).MaximumLength(300);
        }
    }
}
