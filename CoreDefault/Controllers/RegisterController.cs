using CoreDefault.BL.Concrete;
using CoreDefault.BL.ValidationRules;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.EntityFramework;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

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
            WriterValidator wv = new WriterValidator();
            ValidationResult result = wv.Validate(writer);
            var m = Regex.Match(writer.Password, @"((?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,})");
            if (result.IsValid && m.Success)
            {
                writer.Status = true;
                writer.About = "Deneme Test";
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                if (!m.Success)
                {
                    ViewBag.result = "Lütfen şifrenizi en az bir rakam, bir küçük harf ve bir büyük harf içermesine özen gösteriniz!";
                }
            }
            return View();
        }
    }
}
