using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
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
    public class PostCommentManager : IPostCommentService
    {
        IPostCommentDal _postCommentDal;

        public PostCommentManager(IPostCommentDal postCommentDal)
        {
            _postCommentDal = postCommentDal;
        }

        public IResult Add(PostComment postComment)
        {
            IResult result = BusinessRules.Run(CommentLimit(postComment.CustomerId, postComment.PostId));

            if (result != null)
            {
                return result;
            }

            _postCommentDal.Add(postComment);
            return new SuccessResult(Messages.PostCommentAdded);
        }

        public IResult Delete(PostComment postComment)
        {
            _postCommentDal.Delete(postComment);
            return new SuccessResult(Messages.PostCommentDeleted);
        }

        public IDataResult<PostComment> Get(Expression<Func<PostComment, bool>> filter)
        {
            return new SuccessDataResult<PostComment>(_postCommentDal.Get(filter));
        }

        public IDataResult<List<PostComment>> GetAll()
        {
            return new SuccessDataResult<List<PostComment>>(_postCommentDal.GetAll());
        }

        public IResult Update(PostComment postComment)
        {
            _postCommentDal.Update(postComment);
            return new SuccessResult(Messages.PostCommentUpdated);
        }

        private IResult CommentLimit(int customerId, int postId)
        {
            int commentCount = _postCommentDal.GetAll(c => c.CustomerId == customerId && c.PostId == postId).Count;

            if (commentCount > 5)
            {
                return new ErrorResult(Messages.PostCommentLimitExceded);
            }

            return new SuccessResult();
        }
    }
}
