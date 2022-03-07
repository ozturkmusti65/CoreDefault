using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
