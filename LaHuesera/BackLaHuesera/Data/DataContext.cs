using Microsoft.EntityFrameworkCore;
using ModeloLaHuesera.Entidades;
namespace BackLaHuesera.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ModeloLaHuesera.Entidades.Usuario> Usuario { get; set; } = default!;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Pelicula> Peliculas { get; set; }
    }

}
