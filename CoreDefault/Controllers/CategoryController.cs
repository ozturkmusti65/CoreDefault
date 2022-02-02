using CoreDefault.BL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
