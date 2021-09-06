using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("employee_profile_photos")]
    public class EmployeeProfilePhoto : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Column("profile_photo_id")]
        public int ProfilePhotoId { get; set; }
    }
}
