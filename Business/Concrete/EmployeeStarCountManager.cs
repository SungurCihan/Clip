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
    public class EmployeeStarCountManager : IEmployeeStarCountService
    {
        IEmployeeStarCountDal _employeeStarCountDal;

        public EmployeeStarCountManager(IEmployeeStarCountDal employeeStarCountDal)
        {
            _employeeStarCountDal = employeeStarCountDal;
        }

        public IResult Add(EmployeeStarCount employeeStarCount)
        {
            _employeeStarCountDal.Add(employeeStarCount);
            return new SuccessResult(Messages.EmployeeStarCountAdded);
        }

        public IResult Delete(EmployeeStarCount employeeStarCount)
        {
            _employeeStarCountDal.Delete(employeeStarCount);
            return new SuccessResult(Messages.EmployeeStarCountDeleted);
        }

        public IDataResult<EmployeeStarCount> Get(Expression<Func<EmployeeStarCount, bool>> filter)
        {
            return new SuccessDataResult<EmployeeStarCount>(_employeeStarCountDal.Get(filter));
        }

        public IDataResult<List<EmployeeStarCount>> GetAll()
        {
            return new SuccessDataResult<List<EmployeeStarCount>>(_employeeStarCountDal.GetAll());
        }

        public IResult Update(EmployeeStarCount employeeStarCount)
        {
            _employeeStarCountDal.Update(employeeStarCount);
            return new SuccessResult(Messages.EmployeeStarCountUpdated);
        }
    }
}
