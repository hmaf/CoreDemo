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
    public class BlogManager:IBlogService
    {
        IBlogdbl _blogdbl;

        public BlogManager(IBlogdbl blogdbl)
        {
            _blogdbl = blogdbl;
        }
        public void BlogAdd(Blog blog)
        {
            _blogdbl.Insert(blog);
        }

        public void BlogDelete(Blog blog)
        {
            _blogdbl.Delete(blog);
        }

        public void BlogUpdate(Blog blog)
        {
            _blogdbl.Update(blog);
        }

        public List<Blog> GetList()
        {
            return _blogdbl.GetListAll();
        }

        public Blog GetById(int id)
        {
            return _blogdbl.GetById(id);
        }
    }
}
