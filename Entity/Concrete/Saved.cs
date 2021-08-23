using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Saved : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PostId { get; set; }
    }
}
