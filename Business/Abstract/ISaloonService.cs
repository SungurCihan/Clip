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
    public interface ISaloonService
    {
        IDataResult<Saloon> Get(Expression<Func<Saloon, bool>> filter);
        IDataResult<List<Saloon>> GetAll();
        IResult Add(Saloon saloon);
        IResult Update(Saloon saloon);
        IResult Delete(Saloon saloon);
    }
}
