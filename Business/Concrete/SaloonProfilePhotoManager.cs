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
    public class SaloonProfilePhotoManager : ISaloonProfilePhotoService
    {
        ISaloonProfilePhotoDal _saloonProfilePhotoDal;

        public SaloonProfilePhotoManager(ISaloonProfilePhotoDal saloonProfilePhotoDal)
        {
            _saloonProfilePhotoDal = saloonProfilePhotoDal;
        }

        public IResult Add(SaloonProfilePhoto saloonProfilePhoto)
        {
            _saloonProfilePhotoDal.Add(saloonProfilePhoto);
            return new SuccessResult(Messages.SaloonProfilePhotoAdded);
        }

        public IResult Delete(SaloonProfilePhoto saloonProfilePhoto)
        {
            _saloonProfilePhotoDal.Delete(saloonProfilePhoto);
            return new SuccessResult(Messages.SaloonProfilePhotoDeleted);
        }

        public IDataResult<SaloonProfilePhoto> Get(Expression<Func<SaloonProfilePhoto, bool>> filter)
        {
            return new SuccessDataResult<SaloonProfilePhoto>(_saloonProfilePhotoDal.Get(filter));
        }

        public IDataResult<List<SaloonProfilePhoto>> GetAll()
        {
            return new SuccessDataResult<List<SaloonProfilePhoto>>(_saloonProfilePhotoDal.GetAll());
        }

        public IResult Update(SaloonProfilePhoto saloonProfilePhoto)
        {
            _saloonProfilePhotoDal.Update(saloonProfilePhoto);
            return new SuccessResult(Messages.SaloonProfilePhotoUpdated);
        }
    }
}
