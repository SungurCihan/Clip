using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("notifications")]
    public class Notification : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("header")]
        public string Header { get; set; }

        [Column("main_content")]
        public string MainContent { get; set; }
    }
}
