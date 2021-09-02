using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConserns.Validation.FluentValidation;
using Core.Utilities.Business;
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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        [CacheRemoveAspect("ICustomerService.Get")]
        //[SecuredOperation("appointment.add")]
        public IResult Add(Customer customer)
        {
            //IResult result = BusinessRules.Run(IfEmailExist(customer.Email),
            //                                   IfPhoneNumberExist(customer.PhoneNumber));

            //if (result != null)
            //{
            //    return result;
            //}

            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<Customer> Get(Expression<Func<Customer, bool>> filter)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(filter));
        }

        [CacheAspect]
        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }

        //Business Rules
        //public IResult IfEmailExist(string email)
        //{
        //    var dene = _customerDal.Get(c => c.Email == email);
        //    if (dene != null)
        //    {
        //        return new ErrorResult(Messages.CustomerEmailExistMessage);
        //    }
        //    return new SuccessResult();
        //}

        //public IResult IfPhoneNumberExist(string phoneNumber)
        //{
        //    var dene = _customerDal.Get(c => c.PhoneNumber == phoneNumber);
        //    if (dene != null)
        //    {
        //        return new ErrorResult(Messages.CustomerPhoneNumberExistMessage);
        //    }
        //    return new SuccessResult();
        //}
    }
}
