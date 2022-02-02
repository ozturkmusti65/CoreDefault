using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
