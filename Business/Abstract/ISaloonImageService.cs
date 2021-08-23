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
    public interface ISaloonImageService
    {
        IDataResult<SaloonImage> Get(Expression<Func<SaloonImage, bool>> filter);
        IDataResult<List<SaloonImage>> GetAll();
        IResult Add(SaloonImage saloonImage);
        IResult Update(SaloonImage saloonImage);
        IResult Delete(SaloonImage saloonImage);
    }
}
