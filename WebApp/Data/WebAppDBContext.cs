using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{
    public class WebAppDBContext : DbContext
    {
        public DbSet<SiteObject> SiteObjects { get; set; } = null!;
        public WebAppDBContext(DbContextOptions<WebAppDBContext> options) : base(options)
        {
        }
    }
}
