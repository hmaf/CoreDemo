using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager:ICommentService
    {
        private IComment _comment;

        public CommentManager(IComment comment)
        {
            _comment = comment;
        }
        public void CommentAdd(Comment comment)
        {
            _comment.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _comment.GetListAll(x=>x.BlogId==id);
        }
    }
}
