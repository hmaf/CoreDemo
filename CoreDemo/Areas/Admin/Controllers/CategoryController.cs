using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EFCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var result = cm.GetList().ToPagedList(page, 2);
            return View(result);
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            if (!ModelState.IsValid)
                return View(category);
            
            cm.Add(category);
            return RedirectToAction("Index");
        }
    }
}
//get current url address
//var url1 = HttpContext.Request.Path.ToString().Split("/");