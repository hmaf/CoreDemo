using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IMessage2Dal:GenericDal<Message2>
    {
        List<Message2> GetListWithMessageByWriter(int id);
    }
}
