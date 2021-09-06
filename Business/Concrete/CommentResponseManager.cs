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
    public class CommentResponseManager : ICommentResponseService
    {
        ICommentResponseDal _commentResponseDal;

        public CommentResponseManager(ICommentResponseDal commentResponseDal)
        {
            _commentResponseDal = commentResponseDal;
        }

        [ValidationAspect(typeof(CommentResponseValidator))]
        public IResult Add(CommentResponse commentResponse)
        {
            _commentResponseDal.Add(commentResponse);
            return new SuccessResult(Messages.CommentResponseAdded);
        }

        public IResult Delete(CommentResponse commentResponse)
        {
            _commentResponseDal.Delete(commentResponse);
            return new SuccessResult(Messages.CommentResponseDeleted);
        }

        public IDataResult<CommentResponse> Get(Expression<Func<CommentResponse, bool>> filter)
        {
            return new SuccessDataResult<CommentResponse>(_commentResponseDal.Get(filter));
        }

        public IDataResult<List<CommentResponse>> GetAll()
        {
            return new SuccessDataResult<List<CommentResponse>>(_commentResponseDal.GetAll());
        }

        public IResult Update(CommentResponse commentResponse)
        {
            _commentResponseDal.Update(commentResponse);
            return new SuccessResult(Messages.CommentResponseUpdated);
        }
    }
}
