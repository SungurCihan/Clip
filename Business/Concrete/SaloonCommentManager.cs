using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SaloonCommentManager : ISaloonCommentService
    {
        ISaloonCommentDal _saloonCommentDal;
        IAppointmentService _appointmentService;

        public SaloonCommentManager(ISaloonCommentDal saloonCommentDal, IAppointmentService appointmentService)
        {
            _saloonCommentDal = saloonCommentDal;
            _appointmentService = appointmentService;
        }

        public IResult Add(SaloonComment saloonComment)
        {
            IResult result = BusinessRules.Run(SaloonCommentLimit(saloonComment.AppointmentId));

            if (result != null)
            {
                return result;
            }

            _saloonCommentDal.Add(saloonComment);
            return new SuccessResult(Messages.SaloonCommentAdded);
        }

        public IResult Delete(SaloonComment saloonComment)
        {
            _saloonCommentDal.Delete(saloonComment);
            return new SuccessResult(Messages.SaloonCommentDeleted);
        }

        public IDataResult<SaloonComment> Get(Expression<Func<SaloonComment, bool>> filter)
        {
            return new SuccessDataResult<SaloonComment>(_saloonCommentDal.Get(filter));
        }

        public IDataResult<List<SaloonComment>> GetAll()
        {
            return new SuccessDataResult<List<SaloonComment>>(_saloonCommentDal.GetAll());
        }

        public IDataResult<List<SaloonCommentDetailDto>> GetSaloonCommentDetails()
        {
            return new SuccessDataResult<List<SaloonCommentDetailDto>>(_saloonCommentDal.GetSaloonCommentDetails());
        }

        public IResult Update(SaloonComment saloonComment)
        {
            _saloonCommentDal.Update(saloonComment);
            return new SuccessResult(Messages.SaloonCommentUpdated);
        }

        private IResult SaloonCommentLimit(int appointmentId)
        {
            var result = _saloonCommentDal.Get(s => s.AppointmentId == appointmentId);
            var commentToCheckHour = _appointmentService.Get(a => a.Id == appointmentId);

            double endHour = Convert.ToDouble(commentToCheckHour.Data.EndHour);
            double now = Convert.ToDouble(DateTime.Now.Hour) + (Convert.ToDouble(DateTime.Now.Minute) / 100);  

            if (endHour + 0.15 >= now || commentToCheckHour.Data.AppointmentDate.Day + 1 < DateTime.Now.Day)
            {
                return new ErrorResult(Messages.SaloonCommentTimeLimitExceded);
            }

            if (result != null)
            {
                return new ErrorResult(Messages.SaloonCommentLimitExceded);
            }

            return new SuccessResult();
        }
    }
}
