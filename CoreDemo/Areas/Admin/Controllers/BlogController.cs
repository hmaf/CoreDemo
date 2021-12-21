using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concrete;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        #region Static Excel Download 

        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("لیست بلوگ ها");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "نام";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var context = stream.ToArray();
                    return File(context, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "لیست ستاتیک.xlsx");
                }
            }
        }

        public IActionResult BlogListExcel()
        {
            return View();
        }
        List<BlogModel> GetBlogList()
        {
            List<BlogModel> blogModels = new List<BlogModel>
            {
                new BlogModel{ID=1, BlogName = "برنامه نویسی سی شارپ مقدماتی"},
                new BlogModel{ID = 2, BlogName = "خودرو های برقی شرکت تسلا"},
                new BlogModel{ID = 3, BlogName = "المپیک 2022"}
            };
            return blogModels;
        }

        #endregion

        #region Dynamic

        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("لیست داینامیک بلوگ ها");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "نام";

                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var context = stream.ToArray();
                    return File(context, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "لیست داینامیک.xlsx");
                }
            }
        }

        public List<BlogModel> GetBlogTitleList()
        {
            List<BlogModel> blogModel = new List<BlogModel>();
            using (var c= new Context())
            {
                blogModel = c.Blogs.Select(x => new BlogModel
                {
                    ID = x.BlogId,
                    BlogName = x.BlogTitle
                }).ToList();
                return blogModel;
            }
        }


        #endregion
    }
}
