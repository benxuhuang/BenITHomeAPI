using Microsoft.EntityFrameworkCore;

namespace BenITHomeApi.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {
        }
        public DbSet<Article> Articles { get; set; }
    }
}