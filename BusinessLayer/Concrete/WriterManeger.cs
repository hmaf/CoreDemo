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


        public void AddWriter(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        
    }
}
