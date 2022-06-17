using CoreDefault.BL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetListWithCategory();
            return View(values);
        }
        public IActionResult ReadAll(int id)
        {
            ViewBag.i = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }
    }
}
