using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimDal _userOperationClaim;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaim)
        {
            _userOperationClaim = userOperationClaim;
        }

        public IResult Add(UserOperationClaim userOperationClaim)
        {
            _userOperationClaim.Add(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimAdded);
        }

        public IResult Delete(UserOperationClaim userOperationClaim)
        {
            _userOperationClaim.Delete(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimDeleted);
        }

        public IDataResult<UserOperationClaim> Get(Expression<Func<UserOperationClaim, bool>> filter)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaim.Get(filter));
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaim.GetAll());
        }

        public IResult Update(UserOperationClaim userOperationClaim)
        {
            _userOperationClaim.Update(userOperationClaim);
            return new SuccessResult(Messages.UserOperationClaimUpdated);
        }
    }
}
