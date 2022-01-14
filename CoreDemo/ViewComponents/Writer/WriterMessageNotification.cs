using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        CommentManager cm =new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke()
        {
            var res = cm.GetCommentByWriter();
            return View(res);
        }
    }
}
