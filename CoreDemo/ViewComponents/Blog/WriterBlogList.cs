using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterBlogList:ViewComponent
    {
        BlogManager bm=new BlogManager(new EFBlogRepository());

        public IViewComponentResult Invoke()
        {
            var resoult = bm.GetBlogByWriter(2);
            return View(resoult);
        }
    }
}
