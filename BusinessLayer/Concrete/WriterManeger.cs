using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BusinessLayer.Concrete
{
    public class WriterManeger:IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManeger(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void Add(Writer t)
        {
            _writerDal.Insert(t);
        }

        public void Delete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer t)
        {
            _writerDal.Update(t);
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public Writer TGetById(int id)
        {
          return _writerDal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerDal.GetListAll(x => x.WriterId == id);
        }

        public Writer GetWriterByUsername(string username)
        {
            return _writerDal.GetWriterByUsername(username);
        }
    }
}
