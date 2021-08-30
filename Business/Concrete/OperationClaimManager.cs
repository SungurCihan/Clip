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
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _operationClaim;

        public OperationClaimManager(IOperationClaimDal operationClaim)
        {
            _operationClaim = operationClaim;
        }

        public IResult Add(OperationClaim operationClaim)
        {
            _operationClaim.Add(operationClaim);
            return new SuccessResult(Messages.OperationClaimAdded);
        }

        public IResult Delete(OperationClaim operationClaim)
        {
            _operationClaim.Delete(operationClaim);
            return new SuccessResult(Messages.OperationClaimDeleted);
        }

        public IDataResult<OperationClaim> Get(Expression<Func<OperationClaim, bool>> filter)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaim.Get(filter));
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaim.GetAll());
        }

        public IResult Update(OperationClaim operationClaim)
        {
            _operationClaim.Update(operationClaim);
            return new SuccessResult(Messages.OperationClaimUpdated);
        }
    }
}
