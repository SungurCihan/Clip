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
    public class SaloonNotificationManager : ISaloonNotificationService
    {
        ISaloonNotificationDal _notificationDal;

        public SaloonNotificationManager(ISaloonNotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public IResult Add(SaloonNotification saloonNotification)
        {
            _notificationDal.Add(saloonNotification);
            return new SuccessResult(Messages.SaloonNotificationAdded);
        }

        public IResult Delete(SaloonNotification saloonNotification)
        {
            _notificationDal.Delete(saloonNotification);
            return new SuccessResult(Messages.SaloonNotificationDeleted);
        }

        public IDataResult<SaloonNotification> Get(Expression<Func<SaloonNotification, bool>> filter)
        {
            return new SuccessDataResult<SaloonNotification>(_notificationDal.Get(filter));
        }

        public IDataResult<List<SaloonNotification>> GetAll()
        {
            return new SuccessDataResult<List<SaloonNotification>>(_notificationDal.GetAll());
        }

        public IResult Update(SaloonNotification saloonNotification)
        {
            _notificationDal.Update(saloonNotification);
            return new SuccessResult(Messages.SaloonNotificationUpdated);
        }
    }
}
