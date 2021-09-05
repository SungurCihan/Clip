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
    public interface ISystemNotificationService
    {
        IDataResult<SystemNotification> Get(Expression<Func<SystemNotification, bool>> filter);
        IDataResult<List<SystemNotification>> GetAll();
        IResult Add(SystemNotification systemNotification);
        IResult Update(SystemNotification systemNotification);
        IResult Delete(SystemNotification systemNotification);
    }
}
