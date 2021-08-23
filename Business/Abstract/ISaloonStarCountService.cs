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
    public interface ISaloonStarCountService
    {
        IDataResult<SaloonStarCount> Get(Expression<Func<SaloonStarCount, bool>> filter);
        IDataResult<List<SaloonStarCount>> GetAll();
        IResult Add(SaloonStarCount saloonStarCount);
        IResult Update(SaloonStarCount saloonStarCount);
        IResult Delete(SaloonStarCount saloonStarCount);
    }
}
