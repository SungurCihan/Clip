using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public string ImageUrl { get; set; }
    }
}
