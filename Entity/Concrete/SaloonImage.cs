using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SaloonImage : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public int ImageId { get; set; }
    }
}
