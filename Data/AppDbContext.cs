using ApiGestaoProcessos.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiGestaoProcessos.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Processo> Processos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Marcacao> Marcacoes { get; set; }

        public DbSet<Etapa> Etapas { get; set; }

        public DbSet<ProcessoEtapa> ProcessosEtapas { get; set; }

    }
}