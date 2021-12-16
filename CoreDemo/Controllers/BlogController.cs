using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm=new BlogManager(new EFBlogRepository());
        CategoryManager cm=new CategoryManager(new EFCategoryRepository());
        WriterManeger wm=new WriterManeger(new EFWriterRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewData["ID"] = id;
            ViewBag.id = id;
            var values = bm.GetBlogById(id);
            return View(values); 
        }

        public IActionResult BlogListByWriter()
        {
            int getWriterId = wm.GetWriterByUsername(User.Identity.Name).WriterId;

            var values = bm.GetListWithCategoryByWriterBM(getWriterId);
            return View(values);
        }

        public IActionResult BlogAdd()
        {
            List<SelectListItem> categoryValues = (from c in cm.GetList()  
                select new SelectListItem()
            {
                Text = c.CategoryName,
                Value = c.CategoryId.ToString()
            }).ToList();

            ViewBag.cv = categoryValues;
            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            if (!ModelState.IsValid){
                return View(p);
            }
            p.BlogStatus = true;
            p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterId = wm.GetWriterByUsername(User.Identity.Name).WriterId;
            bm.Add(p);
            return RedirectToAction("BlogListByWriter");
        }
        public IActionResult BlogDelete(int id)
        {
            var val = bm.TGetById(id);
            bm.Delete(val);
            return RedirectToAction("BlogListByWriter");
        }

        public IActionResult EditBlog(int id)
        {
            var val = bm.TGetById(id);
            List<SelectListItem> categoryValues = (from c in cm.GetList()  
                select new SelectListItem()
                {
                    Text = c.CategoryName,
                    Value = c.CategoryId.ToString()
                }).ToList();

            ViewBag.cv = categoryValues;
            return View(val);
        }
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            
            bm.Update(p);
            return RedirectToAction("BlogListByWriter");
        }
    }
}
