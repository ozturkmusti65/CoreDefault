using CoreDefault.BL.Concrete;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            writer.Status = true;
            writer.About = "Deneme Test";
            wm.WriterAdd(writer);
            return RedirectToAction("Index","Blog");
        }
    }
}
