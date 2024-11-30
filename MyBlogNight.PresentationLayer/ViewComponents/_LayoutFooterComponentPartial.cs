using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
