using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;
using X.PagedList;
using X.PagedList.Extensions;
namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _DefaultArticleListComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _DefaultArticleListComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int page = 1)
        {
            int pageSize = 3; 
            var values = _articleService.TArticleListWithCategoryAndAppUser();
            var pagedValues = values.ToPagedList(page, pageSize);
            return View(pagedValues);
        }
    }
}
