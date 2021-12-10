using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class Message2Manager : IMessage2Service
    {
        private IMessage2Dal _message2Dal;

        public Message2Manager(IMessage2Dal message2Dal)
        {
            _message2Dal = message2Dal;
        }
        public void Add(Message2 t)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public List<Message2> GetInboxListByWriter(int p)
        {
            return _message2Dal.GetListWithMessageByWriter(p);
        }

        public List<Message2> GetList()
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _message2Dal.GetById(id);
        }

        public void Update(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
