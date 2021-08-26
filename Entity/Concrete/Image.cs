using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("images")]
    public class Image : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("saloon_id")]
        public int SaloonId { get; set; }
        [Column("image_url")]
        public string ImageUrl { get; set; }
    }
}
