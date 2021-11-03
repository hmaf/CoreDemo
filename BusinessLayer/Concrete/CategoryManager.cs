using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategorydbl _categorydbl;

        public CategoryManager(ICategorydbl categorydbl)
        {
            _categorydbl = categorydbl;
        }

        public void Add(Category t)
        {
            _categorydbl.Insert(t);
        }

        public void Delete(Category t)
        {
            _categorydbl.Delete(t);
        }

        public Category GetById(int id)
        {
            return _categorydbl.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categorydbl.GetListAll();
        }

        public void Update(Category t)
        {
            _categorydbl.Update(t);
        }
    }
}
