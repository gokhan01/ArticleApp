using ArticleApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ArticleApp.DAL.Concrete.Contexts
{
    public class ArticleContext : DbContext
    {
        public ArticleContext()
        {
            
        }
        public ArticleContext(DbContextOptions<ArticleContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
