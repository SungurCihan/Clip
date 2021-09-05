using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.DTO_s
{
    public class SaloonCommentDetailDto : IDto
    {
        public int Id { get; set; }
        public int AppointmentId { get; set; }
        public int SaloonId { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal StartHour { get; set; }
        public decimal EndHour { get; set; }
        public string CommentContent { get; set; }
        public bool Status { get; set; }
    }
}
