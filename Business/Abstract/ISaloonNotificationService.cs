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
    public interface ISaloonNotificationService
    {
        IDataResult<SaloonNotification> Get(Expression<Func<SaloonNotification, bool>> filter);
        IDataResult<List<SaloonNotification>> GetAll();
        IResult Add(SaloonNotification saloonNotification);
        IResult Update(SaloonNotification saloonNotification);
        IResult Delete(SaloonNotification saloonNotification);
    }
}
