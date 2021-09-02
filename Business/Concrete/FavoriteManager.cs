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
    public class FavoriteManager : IFavoriteService
    {
        IFavoriteDal _favoriteDal;

        public FavoriteManager(IFavoriteDal favoriteDal)
        {
            _favoriteDal = favoriteDal;
        }

        public IResult Add(Favorite favorite)
        {
            IResult result = BusinessRules.Run(FavoriteLimit(favorite.CustomerId, favorite.SaloonId));

            if (result != null)
            {
                return result;
            }

            _favoriteDal.Add(favorite);
            return new SuccessResult(Messages.FavoriteAdded);
        }

        public IResult Delete(Favorite favorite)
        {
            _favoriteDal.Delete(favorite);
            return new SuccessResult(Messages.FavoriteDeleted);
        }

        public IDataResult<Favorite> Get(Expression<Func<Favorite, bool>> filter)
        {
            return new SuccessDataResult<Favorite>(_favoriteDal.Get(filter));
        }

        public IDataResult<List<Favorite>> GetAll()
        {
            return new SuccessDataResult<List<Favorite>>(_favoriteDal.GetAll());
        }

        public IResult Update(Favorite favorite)
        {
            _favoriteDal.Update(favorite);
            return new SuccessResult(Messages.FavoriteUpdated);
        }

        private IResult FavoriteLimit(int customerId, int saloonId)
        {
            var result = _favoriteDal.Get(f => f.CustomerId == customerId && f.SaloonId == saloonId);

            if (result != null)
            {
                return new ErrorResult(Messages.FavoriteLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
