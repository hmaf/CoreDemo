using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class GetLast3Blog:ViewComponent
    {
        BlogManager bm=new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var value = bm.GetLast3Blog();
            return View(value);
        }
    }
}
