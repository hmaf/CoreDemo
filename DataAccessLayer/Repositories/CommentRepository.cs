using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CommentRepository : GenericDal<Comment>
    {
        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(Comment t)
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListAll()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetListItem()
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}
