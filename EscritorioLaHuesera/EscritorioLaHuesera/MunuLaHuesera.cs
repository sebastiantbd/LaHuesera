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
    public partial class MunuLaHuesera : Form
    {
        public MunuLaHuesera()
        {
            InitializeComponent();
        }

        private void administradorDePeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPelicula objGestionPelicula = new GestionPelicula();
            objGestionPelicula.MdiParent = this;
            objGestionPelicula.Show();
        }
    }
}
