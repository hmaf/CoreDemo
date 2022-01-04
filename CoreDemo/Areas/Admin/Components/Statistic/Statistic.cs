using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Areas.Admin.Components.Statistic
{
    public class Statistic : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c=new Context();
        public IViewComponentResult Invoke()
        {
            ViewData["V1"] = bm.GetList().Count;
            ViewData["V2"] = c.Contacts.Count();
            ViewData["V3"] = c.Comments.Count();
            ViewData["V4"] = WeatherApi().Value;

            return View();
        }
        private XAttribute WeatherApi(string city = "Tabriz")
        {
            string apiKey = "282a4e118584e93c964a2d3774ef42c6";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=" + city + "&mode=xml&units=metric&appid=" + apiKey;
            XDocument document = XDocument.Load(connection);
            return document.Descendants("temperature").ElementAt(0).Attribute("value");
        }
    }
}
