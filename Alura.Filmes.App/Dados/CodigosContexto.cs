using Forms_Ver01.App.Negocio;
using Microsoft.EntityFrameworkCore;


namespace Forms_Ver01.App.Dados
{
    public class CodigosContexto : DbContext
    {
        public DbSet<Codigos> Codigo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          //  optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=UserRegister;Trusted_connection=true;");
            optionsBuilder.UseSqlServer("Data Source=CAIOLAPTOP;Initial Catalog=UserRegisterSQL;Persist Security Info=True;User ID=sa;Password=123;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CodigosConfiguration());
        }
    }
}
