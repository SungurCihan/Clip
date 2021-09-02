using Business.Abstract;
using Business.Constants;
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
    public class SavedManager : ISavedService
    {
        ISavedDal _savedDal;

        public SavedManager(ISavedDal savedDal)
        {
            _savedDal = savedDal;
        }

        public IResult Add(Saved saved)
        {
            IResult result = BusinessRules.Run(SavedLimit(saved.CustomerId, saved.PostId));

            if (result != null)
            {
                return result;
            }

            _savedDal.Add(saved);
            return new SuccessResult(Messages.SavedAdded);
        }

        public IResult Delete(Saved saved)
        {
            _savedDal.Delete(saved);
            return new SuccessResult(Messages.SavedDeleted);
        }

        public IDataResult<Saved> Get(Expression<Func<Saved, bool>> filter)
        {
            return new SuccessDataResult<Saved>(_savedDal.Get(filter));
        }

        public IDataResult<List<Saved>> GetAll()
        {
            return new SuccessDataResult<List<Saved>>(_savedDal.GetAll());
        }

        public IResult Update(Saved saved)
        {
            _savedDal.Update(saved);
            return new SuccessResult(Messages.SavedUpdated);
        }

        private IResult SavedLimit(int customerId, int postId)
        {
            var result = _savedDal.Get(f => f.CustomerId == customerId && f.PostId == postId);

            if (result != null)
            {
                return new ErrorResult(Messages.SavedLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
