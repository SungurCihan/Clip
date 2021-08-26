using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("favorites")]
    public class Favorite : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("saloon_id")]
        public int SaloonId { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
    }
}
