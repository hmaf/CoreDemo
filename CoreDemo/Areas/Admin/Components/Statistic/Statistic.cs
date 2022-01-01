using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Components.Statistic
{
    public class Statistic : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewData["V1"] = bm.GetList().Count;
            ViewData["V2"] = c.Contacts.Count();
            ViewData["V3"] = c.Comments.Count();
            return View();
        }
    }
}
