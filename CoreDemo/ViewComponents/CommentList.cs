using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var comment = new List<CommentUser>
            {
                new CommentUser()
                {
                    Id = 1,
                    Name = "yek"
                },
                new CommentUser()
                {
                    Id = 2,
                    Name = "do"
                },
                new CommentUser()
                {
                    Id = 3,
                    Name = "se"
                }
            };
            return View(comment);
        }
    }
}
