using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
