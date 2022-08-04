using CoreDefault.BL.Concrete;
using CoreDefult.DAL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDefault.Web.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c = new Context(); 
        public IViewComponentResult Invoke()
        {
            ViewBag.BlogSayisi = bm.GetList().Count();
            ViewBag.MesajSayisi = c.Contacts.Count();
            ViewBag.YorumSayisi = c.Comments.Count();
            return View();
        }
    }
}
