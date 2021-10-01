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
        public void CategoryAdd(Category category)
        {
            _categorydbl.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            _categorydbl.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categorydbl.Update(category);
        }

        public Category GetById(int id)
        {
            return _categorydbl.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categorydbl.GetListAll();
        }
    }
}
