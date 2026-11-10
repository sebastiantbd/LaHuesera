using Microsoft.EntityFrameworkCore;
using ModeloLaHuesera.Entidades;
namespace BackLaHuesera.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
    }

}
