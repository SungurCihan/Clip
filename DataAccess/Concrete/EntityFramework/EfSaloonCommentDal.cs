using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSaloonCommentDal : EfEntityRepositoryBase<SaloonComment, ClipContext>, ISaloonCommentDal
    {
        public List<SaloonCommentDetailDto> GetSaloonCommentDetails(Expression<Func<SaloonCommentDetailDto, bool>> filter = null)
        {
            using (ClipContext context = new ClipContext())
            {
                var result = from s in context.SaloonComments
                             join a in context.Appointments
                             on s.AppointmentId equals a.Id
                             join c in context.Comments
                             on s.CommentId equals c.Id
                             select new SaloonCommentDetailDto { Id = s.Id, AppointmentId = s.AppointmentId, AppointmentDate = a.AppointmentDate, 
                                                                CommentContent = c.CommentContent, CustomerId = a.CustomerId, EmployeeId = a.EmployeeId, 
                                                                EndHour = a.EndHour, SaloonId = a.SaloonId, ServiceId = a.ServiceId, StartHour = a.StartHour, 
                                                                Status = a.Status };

                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }

        public SaloonCommentDetailDto GetSaloonCommentDetailsSingular(Expression<Func<SaloonCommentDetailDto, bool>> filter)
        {
            using (ClipContext context = new ClipContext())
            {
                var result = from s in context.SaloonComments
                             join a in context.Appointments
                             on s.AppointmentId equals a.Id
                             join c in context.Comments
                             on s.CommentId equals c.Id
                             select new SaloonCommentDetailDto
                             {
                                 Id = s.Id,
                                 AppointmentId = s.AppointmentId,
                                 AppointmentDate = a.AppointmentDate,
                                 CommentContent = c.CommentContent,
                                 CustomerId = a.CustomerId,
                                 EmployeeId = a.EmployeeId,
                                 EndHour = a.EndHour,
                                 SaloonId = a.SaloonId,
                                 ServiceId = a.ServiceId,
                                 StartHour = a.StartHour,
                                 Status = a.Status
                             };

                return result.SingleOrDefault(filter);
            }
        }
    }
}
