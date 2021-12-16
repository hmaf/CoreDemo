using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashBoard:ViewComponent
    {
        WriterManeger vm=new WriterManeger(new EFWriterRepository());

        public IViewComponentResult Invoke()
        {
            var values = vm.GetWriterByUsername(User.Identity.Name);
            return View(values);
        }

    }
}
