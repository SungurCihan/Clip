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
    public interface INotificationService
    {
        IDataResult<Notification> Get(Expression<Func<Notification, bool>> filter);
        IDataResult<List<Notification>> GetAll();
        IResult Add(Notification notification);
        IResult Update(Notification notification);
        IResult Delete(Notification notification);
    }
}
