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
    public interface IServiceService
    {
        IDataResult<Service> Get(Expression<Func<Service, bool>> filter);
        IDataResult<List<Service>> GetAll();
        IResult Add(Service service);
        IResult Update(Service service);
        IResult Delete(Service service);
    }
}
