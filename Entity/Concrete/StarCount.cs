using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("star_counts")]
    public class StarCount : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("saloon_id")]
        public int SaloonId { get; set; }

        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Column("type_id")]
        public int TypeId { get; set; }

        [Column("appointment_id")]
        public int AppointmentId { get; set; }

        [Column("star_count")]
        public decimal Star { get; set; }
    }
}
