using Microsoft.EntityFrameworkCore;
using MyBlogNight.DataAccessLayer.Abstract;
using MyBlogNight.DataAccessLayer.Context;
using MyBlogNight.DataAccessLayer.Repositories;
using MyBlogNight.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlogNight.DataAccessLayer.EntityFramework
{
    public class EfArticleDal : GenericRepository<Article>, IArticleDal
    {
        public EfArticleDal(BlogContext context) : base(context)
        {
        }
        BlogContext context = new BlogContext(); 
        public List<Article> ArticleListWithCategory()
        {
            var values = context.Articles.Include(x =>x.Category).ToList();
            return values;
        }

        public List<Article> ArticleListWithCategoryAndAppUser()
        {
            var values = context.Articles.Include(x =>x.Category).Include(y => y.AppUser).ToList();
            return values;
        }

        public Article ArticleListWithCategoryAndAppUserByArticleId(int id)
        {
            var value = context.Articles.Where(x => x.ArticleId == id).Include(y => y.AppUser).Include(z => z.Category).FirstOrDefault();
            return value;
        }

        public void ArticleViewCountIncrease(int id)
        {
            var updatedValue = context.Articles.Find(id);
            updatedValue.ArticleViewCount += 1;
            context.SaveChanges();
        }

        public List<Article> GetArticlesByAppUserId(int id)
        {
            var values = context.Articles.Where(x => x.AppUserId == id).ToList();
            return values;
        }

        public List<Article> ResentPosts()
        {
            var values = context.Articles.OrderByDescending(x => x.ArticleId).Take(3).ToList();
            return values;
        }
    }
}
