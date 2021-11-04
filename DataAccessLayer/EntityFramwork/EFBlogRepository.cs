using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramwork
{
    public class EFBlogRepository : GenericRepository<Blog>, IBlogdbl
    {
        public List<Blog> GetListWithCategory()
        {
            using(var c=new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using(var c=new Context())
            {
                return c.Blogs.Include(x => x.Category)
                    .Where(c=>c.WriterId==id).ToList();
            }
        }
    }
}
