using Microsoft.AspNetCore.Mvc;

namespace CoreDefault.Web.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
