using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("employees")]
    public class Employee : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("saloon_id")]
        public int SaloonId { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("rating")]
        public double Rating { get; set; }
    }
}
