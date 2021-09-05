using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("faqs")]
    public class Faq : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("saloon_id")]
        public int SaloonId { get; set; }

        [Column("question")]
        public string Question { get; set; }

        [Column("answer")]
        public string Answer { get; set; }
    }
}
