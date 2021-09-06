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
    public interface IEmployeeProfilePhotoService
    {
        IDataResult<EmployeeProfilePhoto> Get(Expression<Func<EmployeeProfilePhoto, bool>> filter);
        IDataResult<List<EmployeeProfilePhoto>> GetAll();
        IResult Add(EmployeeProfilePhoto employeeProfilePhoto);
        IResult Update(EmployeeProfilePhoto employeeProfilePhoto);
        IResult Delete(EmployeeProfilePhoto employeeProfilePhoto);
    }
}
