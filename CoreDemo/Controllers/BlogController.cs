using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
