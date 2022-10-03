using CoreDefult.DAL.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDefault.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();

            var username = User.Identity.Name;
            ViewBag.veri = username;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(s => s.Id).FirstOrDefault();

            ViewBag.v1 = c.Blogs.Count().ToString();
            ViewBag.v2 = c.Blogs.Where(x => x.WriterId == writerId).Count().ToString();
            ViewBag.v3 = c.Categories.Count().ToString();
            return View();
        }
    }
}
