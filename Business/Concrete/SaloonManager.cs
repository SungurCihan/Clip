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
    public class SaloonManager : ISaloonService
    {
        ISaloonDal _saloonDal;

        public SaloonManager(ISaloonDal saloonDal)
        {
            _saloonDal = saloonDal;
        }

        [ValidationAspect(typeof(SaloonValidator))]
        public IResult Add(Saloon saloon)
        {
            _saloonDal.Add(saloon);
            return new SuccessResult(Messages.SaloonAdded);
        }

        public IResult Delete(Saloon saloon)
        {
            _saloonDal.Delete(saloon);
            return new SuccessResult(Messages.SaloonDeleted);
        }

        public IDataResult<Saloon> Get(Expression<Func<Saloon, bool>> filter)
        {
            return new SuccessDataResult<Saloon>(_saloonDal.Get(filter));
        }

        public IDataResult<List<Saloon>> GetAll()
        {
            return new SuccessDataResult<List<Saloon>>(_saloonDal.GetAll());
        }

        public IResult Update(Saloon saloon)
        {
            _saloonDal.Update(saloon);
            return new SuccessResult(Messages.SaloonUpdated);
        }

        private IResult DublicatePhoneNumber(string phoneNumber)
        {
            var result = _saloonDal.Get(u => u.PhoneNumber == phoneNumber);

            if (result != null)
            {
                return new ErrorResult(Messages.SaloonPhoneNumberRepeats);
            }

            return new SuccessResult();
        }
    }
}
