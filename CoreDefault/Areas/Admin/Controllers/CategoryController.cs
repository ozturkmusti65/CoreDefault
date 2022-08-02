using CoreDefault.BL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace CoreDefault.Web.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        [Area("Admin")]
        public IActionResult Index(int page=1)
        {
            var values = cm.GetList().ToPagedList(page,3);
            return View(values);
        }
    }
}
