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
    public class CategoryRepository : ICategorydbl
    {
        Context _context=new Context();
        public void AddCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Remove(category);
            _context.SaveChanges();
        }

        public void EditCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategory()
        {
          return  _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
           return _context.Categories.Find(id);
        }
    }
}
