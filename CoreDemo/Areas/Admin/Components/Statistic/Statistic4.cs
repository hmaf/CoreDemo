using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Components.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context _context=new Context();
        public IViewComponentResult Invoke()
        {
            var values= _context.Admins.SingleOrDefault(x => x.AdminID == 1);
            ViewData["v1"] = values.Name;
            ViewData["v2"] = values.ImageURL;
            ViewData["v3"] = values.ShortDescrioption;
            return View();
        }
    }
}
