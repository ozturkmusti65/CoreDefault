using CoreDefult.DAL.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDefault.Web.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Blogs.OrderByDescending(x => x.Id).Select(s => s.Title).Take(1).FirstOrDefault();
            return View();
        }
    }
}
