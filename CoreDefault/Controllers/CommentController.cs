using CoreDefault.BL.Concrete;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDefault.Web.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment c)
        {
            c.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            c.Status = true;
            c.BlogId = 2;
            cm.AddComment(c);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values =cm.GetList(id);
            return PartialView(values);
        }
    }
}
