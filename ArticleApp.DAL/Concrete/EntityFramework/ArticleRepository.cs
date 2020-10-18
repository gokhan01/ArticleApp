using ArticleApp.Core.DataAccess.EntityFramework;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.Contexts;
using ArticleApp.Entities;

namespace ArticleApp.DAL.Concrete.EntityFramework
{
    public class ArticleRepository : EfGenericRepository<Article, ArticleContext>, IArticleRepository
    {
    }
}
