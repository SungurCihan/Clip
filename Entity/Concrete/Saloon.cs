using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("saloons")]
    public class Saloon : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("saloon_name")]
        public string SaloonName { get; set; }
        [Column("address")]
        public string Addresss { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("description")]
        public string Description { get; set; }

    }
}
