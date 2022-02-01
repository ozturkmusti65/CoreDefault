using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
