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
    public interface IEmployeeStarCountService
    {
        IDataResult<EmployeeStarCount> Get(Expression<Func<EmployeeStarCount, bool>> filter);
        IDataResult<List<EmployeeStarCount>> GetAll();
        IResult Add(EmployeeStarCount employeeStarCount);
        IResult Update(EmployeeStarCount employeeStarCount);
        IResult Delete(EmployeeStarCount employeeStarCount);
    }
}
