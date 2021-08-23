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
    public class SaloonImageManager : ISaloonImageService
    {
        ISaloonImageDal _saloonImageDal;

        public SaloonImageManager(ISaloonImageDal saloonImageDal)
        {
            _saloonImageDal = saloonImageDal;
        }

        public IResult Add(SaloonImage saloonImage)
        {
            _saloonImageDal.Add(saloonImage);
            return new SuccessResult(Messages.SaloonImageAdded);
        }

        public IResult Delete(SaloonImage saloonImage)
        {
            _saloonImageDal.Delete(saloonImage);
            return new SuccessResult(Messages.SaloonImageDeleted);
        }

        public IDataResult<SaloonImage> Get(Expression<Func<SaloonImage, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SaloonImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(SaloonImage saloonImage)
        {
            _saloonImageDal.Update(saloonImage);
            return new SuccessResult(Messages.SaloonImageUpdated);
        }
    }
}
