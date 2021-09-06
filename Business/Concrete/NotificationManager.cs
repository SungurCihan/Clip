using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        [ValidationAspect(typeof(NotificationValidator))]
        public IResult Add(Notification notification)
        {
            _notificationDal.Add(notification);
            return new SuccessResult(Messages.NotificationAdded);
        }

        public IResult Delete(Notification notification)
        {
            _notificationDal.Delete(notification);
            return new SuccessResult(Messages.NotificationDeleted);
        }

        public IDataResult<Notification> Get(Expression<Func<Notification, bool>> filter)
        {
            return new SuccessDataResult<Notification>(_notificationDal.Get(filter));
        }

        public IDataResult<List<Notification>> GetAll()
        {
            return new SuccessDataResult<List<Notification>>(_notificationDal.GetAll());
        }

        public IResult Update(Notification notification)
        {
            _notificationDal.Update(notification);
            return new SuccessResult(Messages.NotificationUpdated);
        }
    }
}
