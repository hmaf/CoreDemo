using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Components.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
           // ViewData["V1"] = bm.GetList().Count;
            ViewData["V2"] = c.Blogs.OrderByDescending(x=>x.BlogId).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
            ViewData["V3"] = c.Comments.Count();
            return View();
        }
    }
}
