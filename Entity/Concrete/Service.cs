using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Service : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public string ServiceName { get; set; }
        public Double ServicePrice { get; set; }
    }
}
