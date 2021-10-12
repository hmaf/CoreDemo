using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {
        AboutManeger am=new AboutManeger(new EFAboutRepository());
        public IActionResult Index()
        {
            var resoult = am.GetList();
            return View(resoult);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
