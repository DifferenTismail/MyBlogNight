using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using MyBlogNight.EntityLayer.Concrete;

namespace MyBlogNight.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ISubscribeService _subscribeService;

        public DefaultController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewsletter(Subscribe subscribe)
        {

            _subscribeService.TInsert(subscribe);
            TempData["NewsletterMessage"] = "Başarılı bir şekilde abone oldunuz!";
            return RedirectToAction("Index");
        }
    }
}
