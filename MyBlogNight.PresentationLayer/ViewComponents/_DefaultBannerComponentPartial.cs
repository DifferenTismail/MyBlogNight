using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultBannerComponentPartial : ViewComponent
    {
        private readonly ISubscribeService _subscribeService;

        public _DefaultBannerComponentPartial(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public IViewComponentResult Invoke()
        {
            var subscribe = new Subscribe();
            return View(subscribe);
        }
    }
}
