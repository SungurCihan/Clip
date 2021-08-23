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
    public interface IFolowerService
    {
        IDataResult<Folower> Get(Expression<Func<Folower, bool>> filter);
        IDataResult<List<Folower>> GetAll();
        IResult Add(Folower folewer);
        IResult Update(Folower folewer);
        IResult Delete(Folower folewer);
    }
}
