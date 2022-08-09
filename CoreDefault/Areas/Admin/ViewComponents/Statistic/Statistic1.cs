using CoreDefault.BL.Concrete;
using CoreDefult.DAL.Concrete;
using CoreDefult.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;

namespace CoreDefault.Web.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        Context c = new Context(); 
        public IViewComponentResult Invoke()
        {
            ViewBag.BlogSayisi = bm.GetList().Count();
            ViewBag.MesajSayisi = c.Contacts.Count();
            ViewBag.YorumSayisi = c.Comments.Count();

            string api = "997b5b55b05f3eb92952b60796b9bec9";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.v4 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
