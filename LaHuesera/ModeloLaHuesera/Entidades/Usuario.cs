using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloLaHuesera.Entidades
{
    public class Usuario
    {
        public int Id { get; set; } //Campo obligatorio, es la clave primaria por defecto
        //public int CodPelicuta { get; set; } 
        public string Nombre { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
