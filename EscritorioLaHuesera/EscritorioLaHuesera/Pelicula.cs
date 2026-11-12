using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscritorioLaHuesera
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Duracion { get; set; }
        public int Codigo { get; set; }

        public Pelicula()
        {
            Id = 0;
            Nombre = string.Empty;
            Descripcion = string.Empty;
            Duracion = string.Empty;
            Codigo = 0;
        }

        public Pelicula(int id, string nombre, string descripcion, string duracion, int codigo)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = descripcion;
            Duracion = duracion;
            Codigo = codigo;
        }
    }
}
