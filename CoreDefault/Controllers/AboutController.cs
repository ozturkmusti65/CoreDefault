using CoreDefault.BL.Concrete;
using CoreDefult.DAL.Abstract;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDefault.Web.Controllers
{
    public class AboutController : Controller
    {
        AboutManager abm = new AboutManager(new EFAboutRepository());

        public IActionResult Index()
        {
            var values = abm.GetList();
            return View(values);
        }

        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}
