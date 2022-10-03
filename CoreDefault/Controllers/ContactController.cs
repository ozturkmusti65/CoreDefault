using CoreDefault.BL.Concrete;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDefault.Web.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EFContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Status = true;
            cm.ContactAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
