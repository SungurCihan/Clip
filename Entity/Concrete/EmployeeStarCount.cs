using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("employee_star_counts")]
    public class EmployeeStarCount : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("saloon_id")]
        public int SaloonId { get; set; }
        [Column("employee_id")]
        public int EmployeeId { get; set; }
        [Column("star_count")]
        public double StarCount { get; set; }
    }
}
