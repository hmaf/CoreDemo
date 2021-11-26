using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManeger wm=new WriterManeger(new EFWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }
        
        public IActionResult Test()
        {
            return View();
        }

        public IActionResult WriterSidebar()
        {
            return PartialView();
        }

        public IActionResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var profile = wm.TGetById(1);
            return View(profile);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            if (!ModelState.IsValid)
                return View(p);

            wm.Update(p);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
