using ArticleApp.Core.DataAccess;
using ArticleApp.Entities;

namespace ArticleApp.DAL.Abstract
{
    public interface IArticleRepository : IGenericRepository<Article>
    {
    }
}