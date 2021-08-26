using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("social_media_links")]
    public class SocialMediaLink : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("saloon_id")]
        public int SaloonId { get; set; }
        [Column("instagram_link")]
        public string InstagramLink { get; set; }
        [Column("facebook_link")]
        public string FacebookLink { get; set; }
        [Column("twitter_link")]
        public string TwitterLink { get; set; }
        [Column("pinterest_link")]
        public string PinterestLink { get; set; }
        [Column("tiktok_link")]
        public string TiktokLink { get; set; }
    }
}
