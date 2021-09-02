using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class SaloonCommentValidator : AbstractValidator<SaloonComment>
    {
        public SaloonCommentValidator()
        {
            RuleFor(s => s.CommentContent).NotEmpty();
            RuleFor(s => s.CommentContent).MinimumLength(1);
            RuleFor(s => s.CommentContent).MaximumLength(300);
        }
    }
}
