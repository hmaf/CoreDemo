using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;

namespace CoreDemo.Controllers
{
    public class NotificationController : Controller
    {
        NotificationManager nm=new NotificationManager(new EFNotificationRepository());
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AllNotification()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
