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
    public class SaloonStarCountManager : ISaloonStarCountService
    {
        ISaloonStarCountDal _saloonStarCountDal;

        public SaloonStarCountManager(ISaloonStarCountDal saloonStarCountDal)
        {
            _saloonStarCountDal = saloonStarCountDal;
        }

        public IResult Add(SaloonStarCount saloonStarCount)
        {
            _saloonStarCountDal.Add(saloonStarCount);
            return new SuccessResult(Messages.SaloonStarCountAdded);
        }

        public IResult Delete(SaloonStarCount saloonStarCount)
        {
            _saloonStarCountDal.Delete(saloonStarCount);
            return new SuccessResult(Messages.SaloonStarCountDeleted);
        }

        public IDataResult<SaloonStarCount> Get(Expression<Func<SaloonStarCount, bool>> filter)
        {
            return new SuccessDataResult<SaloonStarCount>(_saloonStarCountDal.Get(filter));
        }

        public IDataResult<List<SaloonStarCount>> GetAll()
        {
            return new SuccessDataResult<List<SaloonStarCount>>(_saloonStarCountDal.GetAll());
        }

        public IResult Update(SaloonStarCount saloonStarCount)
        {
            _saloonStarCountDal.Update(saloonStarCount);
            return new SuccessResult(Messages.SaloonStarCountUpdated);
        }
    }
}
