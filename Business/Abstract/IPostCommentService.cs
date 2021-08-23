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
    public interface IPostCommentService
    {
        IDataResult<PostComment> Get(Expression<Func<PostComment, bool>> filter);
        IDataResult<List<PostComment>> GetAll();
        IResult Add(PostComment postComment);
        IResult Update(PostComment postComment);
        IResult Delete(PostComment postComment);
    }
}
