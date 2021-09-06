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
    public class EmployeeProfilePhotoManager : IEmployeeProfilePhotoService
    {
        IEmployeeProfilePhotoDal _employeeProfilePhotoDal;

        public EmployeeProfilePhotoManager(IEmployeeProfilePhotoDal employeeProfilePhotoDal)
        {
            _employeeProfilePhotoDal = employeeProfilePhotoDal;
        }

        public IResult Add(EmployeeProfilePhoto employeeProfilePhoto)
        {
            _employeeProfilePhotoDal.Add(employeeProfilePhoto);
            return new SuccessResult(Messages.EmployeeProfilPhotoAdded);
        }

        public IResult Delete(EmployeeProfilePhoto employeeProfilePhoto)
        {
            _employeeProfilePhotoDal.Delete(employeeProfilePhoto);
            return new SuccessResult(Messages.EmployeeProfilPhotoDeleted);
        }

        public IDataResult<EmployeeProfilePhoto> Get(Expression<Func<EmployeeProfilePhoto, bool>> filter)
        {
            return new SuccessDataResult<EmployeeProfilePhoto>(_employeeProfilePhotoDal.Get(filter));
        }

        public IDataResult<List<EmployeeProfilePhoto>> GetAll()
        {
            return new SuccessDataResult<List<EmployeeProfilePhoto>>(_employeeProfilePhotoDal.GetAll());
        }

        public IResult Update(EmployeeProfilePhoto employeeProfilePhoto)
        {
            _employeeProfilePhotoDal.Update(employeeProfilePhoto);
            return new SuccessResult(Messages.EmployeeProfilPhotoUpdated);
        }
    }
}
