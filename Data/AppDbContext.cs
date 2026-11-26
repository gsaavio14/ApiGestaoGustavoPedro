using ApiGestaoProcessos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGestaoProcessos.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Marcacao> Marcacoes { get; set; }

    }
}