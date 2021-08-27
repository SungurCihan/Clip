using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPostLikeService
    {
        IDataResult<PostLike> Get(Expression<Func<PostLike, bool>> filter);
        IDataResult<List<PostLike>> GetAll();
        IResult Add(PostLike postLike);
        IResult Update(PostLike postLike);
        IResult Delete(PostLike postLike);
    }
}
