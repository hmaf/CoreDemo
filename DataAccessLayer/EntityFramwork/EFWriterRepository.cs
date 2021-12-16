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
    public class EFWriterRepository:GenericRepository<Writer>,IWriterDal
    {
        public Writer GetWriterByUsername(string username)
        {
            using(var c=new Context())
            {
                return c.Writers.SingleOrDefault(w=>w.WriterMail==username);
            }
        }
    }
}
