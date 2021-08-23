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
    public interface IAppointmentService
    {
        IDataResult<Appointment> Get(Expression<Func<Appointment, bool>> filter);
        IDataResult<List<Appointment>> GetAll();
        IResult Add(Appointment appointment);
        IResult Update(Appointment appointment);
        IResult Delete(Appointment appointment);
    }
}
