using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        [ValidationAspect(typeof(CommentValidator))]
        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult(Messages.CommentAdded);
        }

        public IResult Delete(Comment comment)
        {
            _commentDal.Delete(comment);
            return new SuccessResult(Messages.CommentDeleted);
        }

        public IDataResult<Comment> Get(Expression<Func<Comment, bool>> filter)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(filter));
        }

        public IDataResult<List<Comment>> GetAll()
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll());
        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult(Messages.CommentUpdated);
        }
    }
}
