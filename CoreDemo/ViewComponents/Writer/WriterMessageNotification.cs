using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        Message2Manager mm=new Message2Manager(new EFMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int p = 1;
            var res = mm.GetInboxListByWriter(p);
            return View(res);
        }
    }
}
