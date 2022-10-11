using CoreDefault.BL.Concrete;
using CoreDefault.Entity.Concrete;
using CoreDefult.DAL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CoreDefault.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        Message2Manager mm = new Message2Manager(new EFMessage2Repository());
        Context c = new Context();
        public IActionResult InBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();
            var values = mm.GetInboxListByWriter(writerId);
            return View(values);
        }
        public IActionResult SendBox()
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();
            var values = mm.GetSendboxListByWriter(writerId);
            return View(values);
        }
        [HttpGet]
        public IActionResult ComposeMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ComposeMessage(Message2 p)
        {
            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();
            p.SenderId = writerId;
            p.ReveiverId = 8;//ALICI AYARLANACAK
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            mm.TAdd(p);
            return RedirectToAction("SendBox");
        }
    }
}
