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

        [HttpPost]
        public IActionResult AddWriter(WriterClass writer)
        {
            writers.Add(writer);
            var jsonWriter = JsonConvert.SerializeObject(writer);
            return Json(jsonWriter);
        }

        [HttpPost]
        public IActionResult DeleteWriter(int id)
        {
            var writer = writers.SingleOrDefault(w=>w.Id==id);
            writers.Remove(writer);
            return Json(writer);
        }

        public IActionResult UpdateWriter(WriterClass w)
        {
            var writer = writers.SingleOrDefault(x=>x.Id == w.Id);
            writer.Name =  w.Name;
            var jsonWriter= JsonConvert.SerializeObject(w);
            return Json(jsonWriter);
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
