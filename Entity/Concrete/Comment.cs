using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("comments")]
    public class Comment : IEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("comment_content")]
        public string CommentContent { get; set; }
    }
}
