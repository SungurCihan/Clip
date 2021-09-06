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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        [ValidationAspect(typeof(ServiceValidator))]
        public IResult Add(Service service)
        {
            _serviceDal.Add(service);
            return new SuccessResult(Messages.ServiceAdded);
        }

        public IResult Delete(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult(Messages.ServiceDeleted);
        }

        public IDataResult<Service> Get(Expression<Func<Service, bool>> filter)
        {
            return new SuccessDataResult<Service>(_serviceDal.Get(filter));
        }

        public IDataResult<List<Service>> GetAll()
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetAll());
        }

        public IResult Update(Service service)
        {
            _serviceDal.Update(service);
            return new SuccessResult(Messages.ServiceUpdated);
        }
    }
}
