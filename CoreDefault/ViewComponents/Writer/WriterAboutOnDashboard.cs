using CoreDefault.BL.Concrete;
using CoreDefult.DAL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CoreDefault.Web.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EFWriterRepository());

        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            Context c = new Context();
            var writerId = c.Writers.Where(w => w.Mail == usermail).Select(y => y.Id).FirstOrDefault();
            var values = wm.GetWriterById(writerId);
            return View(values);
        }
    }
}
