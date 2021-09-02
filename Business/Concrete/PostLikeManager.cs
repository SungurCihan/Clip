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
    public class PostLikeManager : IPostLikeService
    {
        IPostLikeDal _postLikeDal;

        public PostLikeManager(IPostLikeDal postLikeDal)
        {
            _postLikeDal = postLikeDal;
        }

        public IResult Add(PostLike postLike)
        {
            IResult result = BusinessRules.Run(LikeLimit(postLike.CustomerId, postLike.PostId));

            if (result != null)
            {
                return result;
            }

            _postLikeDal.Add(postLike);
            return new SuccessResult(Messages.PostLikeAdded);
        }

        public IResult Delete(PostLike postLike)
        {
            _postLikeDal.Delete(postLike);
            return new SuccessResult(Messages.PostLikeDeleted);
        }

        public IDataResult<PostLike> Get(Expression<Func<PostLike, bool>> filter)
        {
            return new SuccessDataResult<PostLike>(_postLikeDal.Get(filter));
        }

        public IDataResult<List<PostLike>> GetAll()
        {
            return new SuccessDataResult<List<PostLike>>(_postLikeDal.GetAll());
        }

        public IResult Update(PostLike postLike)
        {
            _postLikeDal.Update(postLike);
            return new SuccessResult(Messages.PostLikeUpdated);
        }

        private IResult LikeLimit(int customerId, int postId)
        {
            var result = _postLikeDal.Get(f => f.CustomerId == customerId && f.PostId == postId);

            if (result != null)
            {
                return new ErrorResult(Messages.PostLikeLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
