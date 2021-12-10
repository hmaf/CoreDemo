﻿using System;
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
    public class EFMessage2Repository:GenericRepository<Message2>, IMessage2Dal
    {
        public List<Message2> GetListWithMessageByWriter(int id)
        {
            using (var c=new Context())
            {
                return c.Message2s.Include(x => x.SenderUser)
                    .Where(x => x.ReceiverId == id).ToList();
            }
        }
    }
}
