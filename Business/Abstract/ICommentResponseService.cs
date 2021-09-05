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
    public interface ICommentResponseService
    {
        IDataResult<CommentResponse> Get(Expression<Func<CommentResponse, bool>> filter);
        IDataResult<List<CommentResponse>> GetAll();
        IResult Add(CommentResponse commentResponse);
        IResult Update(CommentResponse commentResponse);
        IResult Delete(CommentResponse commentResponse);
    }
}
