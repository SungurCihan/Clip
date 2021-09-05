using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("comment_responses")]
    public class CommentResponse : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("comment_id")]
        public int CommentId { get; set; }

        [Column("response_content")]
        public string ResponseContent { get; set; }
    }
}
