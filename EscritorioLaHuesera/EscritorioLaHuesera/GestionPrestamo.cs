using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioLaHuesera
{
    public partial class GestionPrestamo : Form
    {
        public GestionPrestamo()
        {
            InitializeComponent();
        }

        private void GestionPrestamo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'laHueseraDataSetUsu.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.laHueseraDataSetUsu.usuarios);
            // TODO: esta línea de código carga datos en la tabla 'laHueseraDataSetPelis.peliculas' Puede moverla o quitarla según sea necesario.
            this.peliculasTableAdapter.Fill(this.laHueseraDataSetPelis.peliculas);

        }

        private void btAgregarPrestamo_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = Modelo.db.conectar("LaHuesera");

            if (objConector != null)
            {
                int usuarioId = Convert.ToInt32(cbUsuario.SelectedValue);
                int peliculaId = Convert.ToInt32(cbPelicula.SelectedValue);

                string fechaPrestamo = "'" + dateTimePickerPrestamo.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                string fechaEntrega = "'" + dateTimePickerDevolucion.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                string estado = "'Activo'";

                string sql = "insert into prestamos (usuarioId, peliculaId, fechaPrestamo, fechaEntrega, estado) values (" +
                    usuarioId + "," + peliculaId + "," + fechaPrestamo + "," + fechaEntrega + "," + estado + ")";

                int numRegistro = Modelo.db.operar(sql, objConector);

                if (numRegistro > 0)
                {
                    cbPelicula.SelectedIndex = -1;
                    cbUsuario.SelectedIndex = -1;

                    MessageBox.Show("Préstamo creado");
                }
                else
                {
                    MessageBox.Show("Problema agregando préstamo");
                }

                objConector.Close();
            }
        }
    }
}
