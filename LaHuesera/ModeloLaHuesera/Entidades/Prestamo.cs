using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLaHuesera.Entidades
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int PeliculaId { get; set; } 
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string Estado { get; set; } = string.Empty;
    }
}
