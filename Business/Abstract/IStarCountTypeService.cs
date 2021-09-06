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
    public interface IStarCountTypeService
    {
        IDataResult<StarCountType> Get(Expression<Func<StarCountType, bool>> filter);
        IDataResult<List<StarCountType>> GetAll();
        IResult Add(StarCountType starCountType);
        IResult Update(StarCountType starCountType);
        IResult Delete(StarCountType starCountType);
    }
}
