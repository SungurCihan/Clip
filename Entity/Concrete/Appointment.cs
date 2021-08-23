using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public int EmployeeId { get; set; }
        public int CustomerId { get; set; }
        public int ServiceId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double StartHour { get; set; }
        public double EndHour { get; set; }
        public bool Status { get; set; }
    }
}
