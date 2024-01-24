using Microsoft.EntityFrameworkCore;

namespace Oline_Shop.Models.ContextDB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
    }
}
