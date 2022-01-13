using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Areas.Admin.Models;
using Newtonsoft.Json;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var jsonResult = JsonConvert.SerializeObject(writers);
            return Json(jsonResult);
        }

        public IActionResult GetWriterById(int id)
        {
            var findWriter = writers.FirstOrDefault(x=>x.Id==id);
            var JsonWriter = JsonConvert.SerializeObject(findWriter);
            return Json(JsonWriter);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                Id = 1,
                Name = "اتوسا"
            },
            new WriterClass
            {
                Id = 2,
                Name = "علی"
            },
            new WriterClass
            {
                Id = 3,
                Name = "شیوا"
            }
        };
    }
}
