using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramwork;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    { 
        CommentManager cm=new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentCreateDate=DateTime.Now;
            comment.CommentStatus = true;
            cm.CommentAdd(comment);
            return PartialView();
        }
    }
}
