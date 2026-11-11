using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioLaHuesera
{
    public partial class GestionPelicula : Form
    {
        public GestionPelicula()
        {
            InitializeComponent();
        }

        private string urlApi = "https://localhost:44379/api/Peliculas";

        private void btAgregarPelicula_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dynamic respuesta = dbApi.DBApi.Get(urlApi);
            txSalida.Text = respuesta.ToString();
        }
    }
}
