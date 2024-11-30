using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _LayoutHeaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
