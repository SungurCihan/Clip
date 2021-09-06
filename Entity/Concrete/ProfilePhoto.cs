using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("profile_photos")]
    public class ProfilePhoto : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("image_url")]
        public string ImageUrl { get; set; }
    }
}
