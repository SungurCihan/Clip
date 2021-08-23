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
    public interface ISavedService
    {
        IDataResult<Saved> Get(Expression<Func<Saved, bool>> filter);
        IDataResult<List<Saved>> GetAll();
        IResult Add(Saved saved);
        IResult Update(Saved saved);
        IResult Delete(Saved saved);
    }
}
