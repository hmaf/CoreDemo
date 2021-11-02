using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {
           Context db=new Context();
           var dataValue =
               db.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
           if(dataValue != null)
           {
               var claims = new List<Claim>
               {
                   new Claim(ClaimTypes.Name, p.WriterMail)
               };
               var useridentity=new ClaimsIdentity(claims, "a");
               ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);
               await HttpContext.SignInAsync(principal);
               return RedirectToAction("Index", "Blog");
           }
           else
           {
               return View();
           }
        }

        
    }
}

//Context db=new Context();
//var dataValue =
//db.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
//if (dataValue != null)
//{
//HttpContext.Session.SetString("username",p.WriterMail);
//return RedirectToAction("Index", "Blog");
//}
//else
//{
//return View();
//}