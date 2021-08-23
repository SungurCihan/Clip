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
    public class SaloonCommentManager : ISaloonCommentService
    {
        ISaloonCommentDal _saloonCommentDal;

        public SaloonCommentManager(ISaloonCommentDal saloonCommentDal)
        {
            _saloonCommentDal = saloonCommentDal;
        }

        public IResult Add(SaloonComment saloonComment)
        {
            _saloonCommentDal.Add(saloonComment);
            return new SuccessResult(Messages.SaloonCommentAdded);
        }

        public IResult Delete(SaloonComment saloonComment)
        {
            _saloonCommentDal.Delete(saloonComment);
            return new SuccessResult(Messages.SaloonCommentDeleted);
        }

        public IDataResult<SaloonComment> Get(Expression<Func<SaloonComment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SaloonComment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(SaloonComment saloonComment)
        {
            _saloonCommentDal.Update(saloonComment);
            return new SuccessResult(Messages.SaloonCommentUpdated);
        }
    }
}
