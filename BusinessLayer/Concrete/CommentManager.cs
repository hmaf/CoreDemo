using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
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
            return _comment.GetListAll(x => x.BlogId == id);
        }

        public List<Comment> GetCommentByWriter()
        {
            using Context db = new Context();
            
           return db.Comments.Include(c => c.Blog).ThenInclude(c => c.Writer)
                .Where(c => c.BlogId == c.Blog.BlogId && c.Blog.WriterId == 1).ToList();
            
            
        }
    }
}
