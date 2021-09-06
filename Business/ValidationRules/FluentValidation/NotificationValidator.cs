using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class NotificationValidator : AbstractValidator<Notification>
    {
        public NotificationValidator()
        {
            //Header
            RuleFor(n => n.Header).NotEmpty();
            RuleFor(n => n.Header).MinimumLength(1);
            RuleFor(n => n.Header).MaximumLength(50);

            //Main Content
            RuleFor(n => n.MainContent).NotEmpty();
            RuleFor(n => n.MainContent).MinimumLength(1);
            RuleFor(n => n.MainContent).MaximumLength(50);
        }
    }
}
