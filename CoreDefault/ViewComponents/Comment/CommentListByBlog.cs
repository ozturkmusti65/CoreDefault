using CoreDefault.BL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
