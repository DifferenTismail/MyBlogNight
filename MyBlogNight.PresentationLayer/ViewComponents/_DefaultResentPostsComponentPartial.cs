using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultResentPostsComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultResentPostsComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var resentPosts = _articleService.TResentPosts();
            return View(resentPosts);
        }
    }
}
