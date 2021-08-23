using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class SocialMediaLink : IEntity
    {
        public int Id { get; set; }
        public int SaloonId { get; set; }
        public string InstagramLink { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string PinterestLink { get; set; }
        public string TiktokLink { get; set; }
    }
}
