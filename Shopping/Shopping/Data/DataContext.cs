using Microsoft.EntityFrameworkCore;
using Shopping.Data.Entities;

namespace Shopping.Data
{
    public class DataContext: DbContext
    {
        //Constructor de conexion a la BD.
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }
        //Intanciar Objeto DB Country
        public DbSet<Country> Countries { get; set; }

        //Modificando una tabla, agregar indice
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }

    }
}
