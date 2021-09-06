using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProfilePhotoService
    {
        IDataResult<ProfilePhoto> Get(Expression<Func<ProfilePhoto, bool>> filter);
        IDataResult<List<ProfilePhoto>> GetAll();
        IResult Add(ProfilePhoto profilePhoto);
        IResult Update(ProfilePhoto profilePhoto);
        IResult Delete(ProfilePhoto profilePhoto);
    }
}
