using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("saloon_notifications")]
    public class SaloonNotification : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("saloon_id")]
        public int SaloonId { get; set; }

        [Column("notification_id")]
        public int NotificationId { get; set; }

        [Column("appointment_id")]
        public int AppointmentId { get; set; }
    }
}
