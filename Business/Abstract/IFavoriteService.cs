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
    public interface IFavoriteService
    {
        IDataResult<Favorite> Get(Expression<Func<Favorite, bool>> filter);
        IDataResult<List<Favorite>> GetAll();
        IResult Add(Favorite favorite);
        IResult Update(Favorite favorite);
        IResult Delete(Favorite favorite);
    }
}
