using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManeger wm=new WriterManeger(new EFWriterRepository());
        public IActionResult Index()
        {
            List<CityForWriterViewModel> city=new List<CityForWriterViewModel>
            {
                new CityForWriterViewModel()
                {
                    CityId = 1,
                    CityName = "تهران"
                },new CityForWriterViewModel()
                {
                    CityId = 2,
                    CityName = "تبریز"
                },new CityForWriterViewModel()
                {
                    CityId = 3,
                    CityName = "ارومیه"
                },new CityForWriterViewModel()
                {
                    CityId = 4,
                    CityName = "اصفهان"
                },new CityForWriterViewModel()
                {
                    CityId = 5,
                    CityName = "شیراز",

                },new CityForWriterViewModel()
                {
                    CityId = 6,
                    CityName = "مشهد"
                },new CityForWriterViewModel()
                {
                    CityId = 7,
                    CityName = "کرمانشاه"
                },new CityForWriterViewModel()
                {
                    CityId = 8,
                    CityName = "خرم آباد"
                }
            };
            var cityWriter = city.Select(c => new SelectListItem()
            {
                Value = c.CityId.ToString(),
                Text = c.CityName
            });
            ViewData["City"]=new SelectList(cityWriter,"Value","Text");
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer p,string RePassword,string CityName)
        {
            if (!ModelState.IsValid)
            {
                return View(p);
            }

            if (p.WriterPassword==RePassword)
            {
                p.WriterStatus = true;
                p.WriterAbout = "test";
                wm.Add(p);
            }
            else
            {
                ModelState.AddModelError("WriterPassword","تکرار کلمه عبور را درست وارد کنید");
                return View(p);
            }
            
            return RedirectToAction("Index", "Blog");
        }

    
       
    }
}
