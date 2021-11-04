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
        
        public List<Blog> GetList()
        {
            return _blogdbl.GetListAll();
        }

        public List<Blog> GetLast3Blog()
        {
            return _blogdbl.GetListAll().Take(3).ToList();
        }
        public Blog TGetById(int id)
        {
            return _blogdbl.GetById(id);
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogdbl.GetListAll(x => x.BlogId == id);
        }
        public List<Blog> GetBlogListWithCategory()
        {
            return _blogdbl.GetListWithCategory();
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return _blogdbl.GetListAll(x => x.WriterId == id);
        }

        public void Add(Blog t)
        {
            _blogdbl.Insert(t);

        }

        public void Delete(Blog t)
        {
            _blogdbl.Delete(t);
        }

        public void Update(Blog t)
        {
            _blogdbl.Update(t);
        }

        public List<Blog> GetListWithCategoryByWriterBM(int id)
        {
            return _blogdbl.GetListWithCategoryByWriter(id);
        }
    }
}
