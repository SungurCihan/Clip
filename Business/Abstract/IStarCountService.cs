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
    public interface IStarCountService 
    {
        IDataResult<StarCount> Get(Expression<Func<StarCount, bool>> filter);
        IDataResult<List<StarCount>> GetAll();
        IResult Add(StarCount starCount);
        IResult Update(StarCount starCount);
        IResult Delete(StarCount starCount);
    }
}
