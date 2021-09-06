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
    public class StarCountManager : IStarCountService
    {
        IStarCountDal _starCountDal;

        public StarCountManager(IStarCountDal starCountDal)
        {
            _starCountDal = starCountDal;
        }

        [ValidationAspect(typeof(StarCountValidator))]
        public IResult Add(StarCount starCount)
        {
            _starCountDal.Add(starCount);
            return new SuccessResult(Messages.StarCountAdded);
        }

        public IResult Delete(StarCount starCount)
        {
            _starCountDal.Delete(starCount);
            return new SuccessResult(Messages.StarCountDeleted);
        }

        public IDataResult<StarCount> Get(Expression<Func<StarCount, bool>> filter)
        {
            return new SuccessDataResult<StarCount>(_starCountDal.Get(filter));
        }

        public IDataResult<List<StarCount>> GetAll()
        {
            return new SuccessDataResult<List<StarCount>>(_starCountDal.GetAll());
        }

        public IResult Update(StarCount starCount)
        {
            _starCountDal.Update(starCount);
            return new SuccessResult(Messages.StarCountUpdated);
        }
    }
}
