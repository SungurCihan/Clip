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
    public interface IPostService
    {
        IDataResult<Post> Get(Expression<Func<Post, bool>> filter);
        IDataResult<List<Post>> GetAll();
        IResult Add(Post post);
        IResult Update(Post post);
        IResult Delete(Post post);
    }
}
