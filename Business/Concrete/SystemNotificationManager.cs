using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SystemNotificationManager : ISystemNotificationService
    {
        ISystemNotificationDal _systemNotificationDal;

        public SystemNotificationManager(ISystemNotificationDal systemNotificationDal)
        {
            _systemNotificationDal = systemNotificationDal;
        }

        public IResult Add(SystemNotification systemNotification)
        {
            _systemNotificationDal.Add(systemNotification);
            return new SuccessResult(Messages.SystemNotificationAdded);
        }

        public IResult Delete(SystemNotification systemNotification)
        {
            _systemNotificationDal.Delete(systemNotification);
            return new SuccessResult(Messages.SystemNotificationDeleted);
        }

        public IDataResult<SystemNotification> Get(Expression<Func<SystemNotification, bool>> filter)
        {
            return new SuccessDataResult<SystemNotification>(_systemNotificationDal.Get(filter));
        }

        public IDataResult<List<SystemNotification>> GetAll()
        {
            return new SuccessDataResult<List<SystemNotification>>(_systemNotificationDal.GetAll());
        }

        public IResult Update(SystemNotification systemNotification)
        {
            _systemNotificationDal.Update(systemNotification);
            return new SuccessResult(Messages.SystemNotificationUpdated);
        }
    }
}
