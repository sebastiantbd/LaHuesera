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
        private string rol;
        private Login objLogin;
        public MunuLaHuesera(string rol, Login objLogin)
        {
            InitializeComponent();
            this.rol = rol;
            this.objLogin = objLogin;
            if (rol == "Cliente")
            {
                gestionDePeliculasToolStripMenuItem.Enabled = false;
                gestionDeUsuariosToolStripMenuItem.Enabled = false;
            }
            if (rol == "Taquillero")
            {
                gestionDePeliculasToolStripMenuItem.Enabled = false;
            }
        }

        private void administradorDePeliculasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPelicula objGestionPelicula = new GestionPelicula();
            objGestionPelicula.MdiParent = this;
            objGestionPelicula.Show();
        }

        private void administradorDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionUsuario objGestionUsuario = new GestionUsuario();
            objGestionUsuario.MdiParent = this;
            objGestionUsuario.Show();
        }

        private void administradorDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPrestamo objGestionPrestamo = new GestionPrestamo();
            objGestionPrestamo.MdiParent = this;
            objGestionPrestamo.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objLogin.Show();
            this.Close();
        }

        private void salirDelProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
