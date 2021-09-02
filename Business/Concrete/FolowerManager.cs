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
    public class FolowerManager : IFolowerService
    {
        IFolowerDal _folowerDal;

        public FolowerManager(IFolowerDal folowerDal)
        {
            _folowerDal = folowerDal;
        }

        public IResult Add(Folower folewer)
        {
            IResult result = BusinessRules.Run(FollowLimit(folewer.CustomerId, folewer.SaloonId));

            if (result != null)
            {
                return result;
            }

            _folowerDal.Add(folewer);
            return new SuccessResult(Messages.FolowerAdded);
        }

        public IResult Delete(Folower folewer)
        {
            _folowerDal.Delete(folewer);
            return new SuccessResult(Messages.FavoriteDeleted);
        }

        public IDataResult<Folower> Get(Expression<Func<Folower, bool>> filter)
        {
            return new SuccessDataResult<Folower>(_folowerDal.Get(filter));
        }

        public IDataResult<List<Folower>> GetAll()
        {
            return new SuccessDataResult<List<Folower>>(_folowerDal.GetAll());
        }

        public IResult Update(Folower folewer)
        {
            _folowerDal.Update(folewer);
            return new SuccessResult(Messages.FavoriteUpdated);
        }

        private IResult FollowLimit(int customerId, int saloonId)
        {
            var result = _folowerDal.Get(f => f.CustomerId == customerId && f.SaloonId == saloonId);

            if (result != null)
            {
                return new ErrorResult(Messages.FolowLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
