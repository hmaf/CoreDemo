using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager mm=new Message2Manager(new EFMessage2Repository());
        public IActionResult InBox()
        {
            int id = 1;
            var res = mm.GetInboxListByWriter(id);
            return View(res);
        }

        public IActionResult MessageDetails(int id)
        {
            var message = mm.TGetById(id);
            return View(message);
        }
    }
}
