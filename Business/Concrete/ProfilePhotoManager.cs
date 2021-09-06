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
    public class ProfilePhotoManager : IProfilePhotoService
    {
        IProfilePhotoDal _profilePhotoDal;

        public ProfilePhotoManager(IProfilePhotoDal profilePhotoDal)
        {
            _profilePhotoDal = profilePhotoDal;
        }

        public IResult Add(ProfilePhoto profilePhoto)
        {
            _profilePhotoDal.Add(profilePhoto);
            return new SuccessResult(Messages.ProfilePhotoAdded);
        }

        public IResult Delete(ProfilePhoto profilePhoto)
        {
            _profilePhotoDal.Delete(profilePhoto);
            return new SuccessResult(Messages.ProfilePhotoDeleted);
        }

        public IDataResult<ProfilePhoto> Get(Expression<Func<ProfilePhoto, bool>> filter)
        {
            return new SuccessDataResult<ProfilePhoto>(_profilePhotoDal.Get(filter));
        }

        public IDataResult<List<ProfilePhoto>> GetAll()
        {
            return new SuccessDataResult<List<ProfilePhoto>>(_profilePhotoDal.GetAll());
        }

        public IResult Update(ProfilePhoto profilePhoto)
        {
            _profilePhotoDal.Update(profilePhoto);
            return new SuccessResult(Messages.ProfilePhotoUpdated);
        }
    }
}
