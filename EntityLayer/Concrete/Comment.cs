using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentCreateDate { get; set; }
        public int BlogScore { get; set; }
        public bool CommentStatus { get; set; }

        #region Relation

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        #endregion
    }
}
