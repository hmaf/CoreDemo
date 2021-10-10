using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramwork;

namespace CoreDemo.Controllers
{
    public class NewsletterController : Controller
    {
        NewsletterManeger nm=new NewsletterManeger(new EFNewsletterRepository());
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(Newsletter p)
        {
            p.Status = true;
            nm.AddNewsletter(p);

            return PartialView();
        }
    }
}
