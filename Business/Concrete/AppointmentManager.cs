using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
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

        //[SecuredOperation("appointment.add,admin")]
        public IResult Add(Appointment appointment)
        {
            IResult result = BusinessRules.Run(AppointmentTimeRange(appointment.EmployeeId, appointment.StartHour, appointment.EndHour, appointment.AppointmentDate));

            if (result != null)
            {
                return result;
            }

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

        private IResult AppointmentTimeRange(int employeeId, decimal startHour, decimal endHour, DateTime date)
        {
            var resultForStart = _appointmentDal.Get(a => Convert.ToDouble(a.StartHour) < Convert.ToDouble(startHour) && Convert.ToDouble(startHour) < Convert.ToDouble(a.EndHour) && a.EmployeeId == employeeId && a.AppointmentDate == date && a.Status == true);
            var resultForEnd = _appointmentDal.Get(a => Convert.ToDouble(a.StartHour) < Convert.ToDouble(endHour) && Convert.ToDouble(endHour) < Convert.ToDouble(a.EndHour) && a.EmployeeId == employeeId && a.AppointmentDate == date && a.Status == true);

            if (resultForStart != null || resultForEnd != null)
            {
                return new ErrorResult(Messages.AppointmentConflict);
            }
            return new SuccessResult();
        }

        private IResult AppointmentHourConsistency(int startHour, int endHour)
        {
            if (startHour >= endHour)
            {
                return new ErrorResult(Messages.AppointmentTimeRange);
            }

            return new SuccessResult();
        }
    }
}

