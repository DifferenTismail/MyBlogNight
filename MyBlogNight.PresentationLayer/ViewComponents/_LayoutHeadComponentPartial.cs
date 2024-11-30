using Microsoft.AspNetCore.Mvc;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
