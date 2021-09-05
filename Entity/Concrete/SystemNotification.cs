using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("system_notifications")]
    public class SystemNotification : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("notification_id")]
        public int NotificationId { get; set; }
    }
}
