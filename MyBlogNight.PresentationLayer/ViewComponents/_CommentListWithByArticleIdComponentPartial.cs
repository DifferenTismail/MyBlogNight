using Microsoft.AspNetCore.Mvc;
using MyBlogNight.BusinessLayer.Abstract;

namespace MyBlogNight.PresentationLayer.ViewComponents
{
    public class _CommentListWithByArticleIdComponentPartial :ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentListWithByArticleIdComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke()
        {
            _commentService.TGetById(1);
            return View();
        }
    }
}
