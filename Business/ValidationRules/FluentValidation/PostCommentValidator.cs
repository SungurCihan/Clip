using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PostCommentValidator : AbstractValidator<PostComment>
    {
        public PostCommentValidator()
        {
            RuleFor(p => p.CommentContent).NotEmpty();
            RuleFor(p => p.CommentContent).MinimumLength(1);
            RuleFor(p => p.CommentContent).MaximumLength(200);
        }
    }
}
