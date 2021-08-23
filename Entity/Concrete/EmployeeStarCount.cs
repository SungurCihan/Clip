using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class EmployeeStarCount : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public int EmployeeId { get; set; }
        public double StarCount { get; set; }
    }
}
