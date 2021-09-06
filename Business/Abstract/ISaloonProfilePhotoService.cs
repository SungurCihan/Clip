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
    public interface ISaloonProfilePhotoService
    {
        IDataResult<SaloonProfilePhoto> Get(Expression<Func<SaloonProfilePhoto, bool>> filter);
        IDataResult<List<SaloonProfilePhoto>> GetAll();
        IResult Add(SaloonProfilePhoto saloonProfilePhoto);
        IResult Update(SaloonProfilePhoto saloonProfilePhoto);
        IResult Delete(SaloonProfilePhoto saloonProfilePhoto);
    }
}
