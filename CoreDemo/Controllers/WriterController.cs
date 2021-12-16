using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using CoreDemo.Models;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManeger wm=new WriterManeger(new EFWriterRepository());
        [Authorize]
        public IActionResult Index()
        {
            ViewData["WriterName"] = wm.GetWriterByUsername(User.Identity.Name).WriterName;
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
            int getWriterId = wm.GetWriterByUsername(User.Identity.Name).WriterId;
            var profile = wm.TGetById(getWriterId);
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

        public IActionResult WriterAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImageViewModel p)
        {
            if (!ModelState.IsValid)
                return View(p);

            Writer writer=new Writer();
            if (p.WriterImageName != null)
            {
                var extension = Path.GetExtension(p.WriterImageName.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newimagename);
                var stream=new FileStream(location,FileMode.Create);
                p.WriterImageName.CopyTo(stream);
                writer.WriterImageName = newimagename;
            }

            writer.WriterName = p.WriterName;
            writer.WriterAbout = p.WriterAbout;
            writer.WriterPassword = p.WriterPassword;
            writer.WriterMail = p.WriterMail;
            writer.WriterStatus = true;
            wm.Add(writer);
            return RedirectToAction("Index","Dashboard");
        }
    }
}
