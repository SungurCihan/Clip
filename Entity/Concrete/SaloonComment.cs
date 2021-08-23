using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SaloonComment : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public int CustomerId { get; set; }
        public string CommentContent { get; set; }
    }
}
