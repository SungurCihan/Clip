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
    public class StarCountTypeManager : IStarCountTypeService
    {
        IStarCountTypeDal _starCountTypeDal;

        public StarCountTypeManager(IStarCountTypeDal starCountTypeDal)
        {
            _starCountTypeDal = starCountTypeDal;
        }

        [ValidationAspect(typeof(StarCountTypeValidator))]
        public IResult Add(StarCountType starCountType)
        {
            _starCountTypeDal.Add(starCountType);
            return new SuccessResult(Messages.StarCountTypeAdded);
        }

        public IResult Delete(StarCountType starCountType)
        {
            _starCountTypeDal.Delete(starCountType);
            return new SuccessResult(Messages.StarCountTypeDeleted);
        }

        public IDataResult<StarCountType> Get(Expression<Func<StarCountType, bool>> filter)
        {
            return new SuccessDataResult<StarCountType>(_starCountTypeDal.Get(filter));
        }

        public IDataResult<List<StarCountType>> GetAll()
        {
            return new SuccessDataResult<List<StarCountType>>(_starCountTypeDal.GetAll());
        }

        public IResult Update(StarCountType starCountType)
        {
            _starCountTypeDal.Update(starCountType);
            return new SuccessResult(Messages.StarCountTypeUpdated);
        }
    }
}
