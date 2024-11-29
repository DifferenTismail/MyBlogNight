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
            var values = _commentService.TGetCommentsByArticleId(1);
            return View(values);
        }
    }
}
