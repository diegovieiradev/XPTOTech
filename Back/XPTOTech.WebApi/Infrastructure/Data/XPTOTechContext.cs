using Microsoft.EntityFrameworkCore;
using XPTOTech.WebApi.Domain.Entities;

namespace XPTOTech.WebApi.Infrastructure.Data
{
    public class XPTOTechContext : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Pooling=true;Database=XPTO_TECH;User Id=postegres;Password=123456;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(XPTOTechContext).Assembly);
        }
    }
}
