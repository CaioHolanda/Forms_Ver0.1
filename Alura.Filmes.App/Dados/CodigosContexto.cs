using Forms_Ver01.App.Negocio;
using Microsoft.EntityFrameworkCore;


namespace Forms_Ver01.App.Dados
{
    public class CodigosContexto : DbContext
    {
        public DbSet<Codigos> Codigo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UserRegister;Trusted_connection=true;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CodigosConfiguration());
        }
    }
}
