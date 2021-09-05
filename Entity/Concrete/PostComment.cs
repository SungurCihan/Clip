using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("post_comments")]
    public class PostComment : IEntity
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("post_id")]
        public int PostId { get; set; }
        [Column("comment_id")]
        public int CommentId { get; set; }
    }
}
