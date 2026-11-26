using Microsoft.EntityFrameworkCore;

namespace ApiGestaoProcessos.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

    }
}