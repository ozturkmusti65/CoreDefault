using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
