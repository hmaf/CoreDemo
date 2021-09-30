using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface GenericDal<T> where T: class 
    {
    void Insert(T t);
    void Delete(T t);
    void Update(T t);
    List<T> GetListItem();
    T GetById(int t);
    }
}
