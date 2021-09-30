﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogdbl
    {
        public void AddBlog(Blog blog)
        {
            using var c=new Context();
            c.Add(blog);
            c.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var c=new Context();
            c.Remove(blog);
            c.SaveChanges();
        }

        public void EditBlog(Blog blog)
        {
            using var c =new Context();
            c.Update(blog);
            c.SaveChanges();
        }

        public List<Blog> GetAllBlog()
        {
            using var c=new Context();
          return  c.Blogs.ToList();
        }

        public Blog GetBlogById(int id)
        {
           using var c=new Context();
           return c.Blogs.Find(id);
        }
    }
}