using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Saloon : IEntity
    {
        public int Id { get; set; }
        public string SaloonName { get; set; }
        public string Addresss { get; set; }
        public string PhoneNumber { get; set; }
        public string description { get; set; }

    }
}
