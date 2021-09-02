﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("appointments")]
    public class Appointment : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("saloon_id")]
        public int SaloonId { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("service_id")]
        public int ServiceId { get; set; }
        [Column("appointment_date")]
        public DateTime AppointmentDate { get; set; }
        [Column("start_hour")]
        public TimeSpan StartHour { get; set; }
        [Column("end_hour")]
        public TimeSpan EndHour { get; set; }
        [Column("status")]
        public bool Status { get; set; }
    }
}
