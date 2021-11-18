using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;

namespace CoreDemo.Controllers
{
    public class DashboardController : Controller
    {
        BlogManager bm=new BlogManager(new EFBlogRepository());
        CategoryManager cm=new CategoryManager(new EFCategoryRepository());
        public IActionResult Index()
        {
            ViewBag.categoryCount = cm.GetList().Count();
            ViewBag.blogCount = bm.GetList().Count();
            ViewBag.blogByWriter = bm.GetBlogByWriter(1).Count();
            return View();
        }
    }
}
