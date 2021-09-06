using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("saloon_profile_photos")]
    public class SaloonProfilePhoto : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("saloon_id")]
        public int SaloonId { get; set; }

        [Column("profile_photo_id")]
        public int ProfilePhotoId { get; set; }
    }
}
