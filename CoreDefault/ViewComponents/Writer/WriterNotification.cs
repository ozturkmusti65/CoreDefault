using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
