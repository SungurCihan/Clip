using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class AppointmentManager : IAppointmentService
    {
        IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        [SecuredOperation("appointment.add,admin")]
        public IResult Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
            return new SuccessResult(Messages.AppointmentAdded);
        }

        public IResult Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
            return new SuccessResult(Messages.AppointmentDeleted);
        }

        public IDataResult<Appointment> Get(Expression<Func<Appointment, bool>> filter)
        {
            return new SuccessDataResult<Appointment>(_appointmentDal.Get(filter));
        }

        public IDataResult<List<Appointment>> GetAll()
        {
            return new SuccessDataResult<List<Appointment>>(_appointmentDal.GetAll());
        }

        public IResult Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
            return new SuccessResult(Messages.AppointmentUpdated);
        }
    }
}
