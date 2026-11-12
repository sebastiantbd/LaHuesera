using EscritorioLaHuesera.dbApi;
using Microsoft.VisualBasic;
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
    public partial class GestionPelicula : Form
    {
        public GestionPelicula()
        {
            InitializeComponent();
        }

        private int idPeliculaEditar;

        //private string urlApi = "https://localhost:44379/api/Peliculas";

        private void btAgregarPelicula_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = Modelo.db.conectar("LaHuesera");
            if (objConector != null)
            {
                string nombre = "'" + txNombre.Text + "'";
                string descripcion = "'" + txDescripcion.Text + "'";
                string duracion = "'" + txDuracion.Text + "'";
                int codigo = Int32.Parse(txCodigo.Text);

                string sql = "insert into peliculas values(" +
                    nombre + "," + descripcion + "," + duracion +
                    "," + codigo + ")";
                int numRegistro = Modelo.db.operar(sql, objConector);
                if (numRegistro > 0)
                {
                    txNombre.Clear();
                    txDescripcion.Clear();
                    txDuracion.Clear();
                    txCodigo.Clear();
                    MessageBox.Show("Película creada");
                }
                else
                {
                    MessageBox.Show("Problema agregando película");
                }

            }
        }
        private void LimpiarCampos()
        {
            txNombre.Clear();
            txDescripcion.Clear();
            txDuracion.Clear();
            txCodigo.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Form ventana = new Form();
                ventana.Text = "Buscar película";
                ventana.Size = new Size(300, 160);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
                ventana.MaximizeBox = false;
                ventana.MinimizeBox = false;

                Label lblId = new Label();
                lblId.Text = "Ingrese el ID de la película:";
                lblId.Location = new Point(15, 15);
                lblId.AutoSize = true;

                TextBox txtId = new TextBox();
                txtId.Location = new Point(15, 45);
                txtId.Width = 250;

                Button btnAceptar = new Button();
                btnAceptar.Text = "Aceptar";
                btnAceptar.Location = new Point(35, 80);
                btnAceptar.DialogResult = DialogResult.OK;

                Button btnCancelar = new Button();
                btnCancelar.Text = "Cancelar";
                btnCancelar.Location = new Point(145, 80);
                btnCancelar.DialogResult = DialogResult.Cancel;

                ventana.Controls.Add(lblId);
                ventana.Controls.Add(txtId);
                ventana.Controls.Add(btnAceptar);
                ventana.Controls.Add(btnCancelar);

                ventana.AcceptButton = btnAceptar;
                ventana.CancelButton = btnCancelar;

                if (ventana.ShowDialog() != DialogResult.OK)
                    return;

                if (!int.TryParse(txtId.Text, out idPeliculaEditar))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                SqlConnection objConector = Modelo.db.conectar("LaHuesera");

                if (objConector != null)
                {
                    string sql = "SELECT nombre, descripcion, duracion, codigo " +
                                 "FROM peliculas WHERE id = " + idPeliculaEditar;

                    SqlCommand comando = new SqlCommand(sql, objConector);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        txNombre.Text = lector["nombre"].ToString();
                        txDescripcion.Text = lector["descripcion"].ToString();
                        txDuracion.Text = lector["duracion"].ToString();
                        txCodigo.Text = lector["codigo"].ToString();

                        MessageBox.Show("Película encontrada. Ahora puede modificar sus datos.",
                                        "Búsqueda exitosa",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la película.");
                    }

                    lector.Close();
                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la película: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btEditarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                Form ventana = new Form();
                ventana.Text = "Buscar película";
                ventana.Size = new Size(300, 160);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
                ventana.MaximizeBox = false;
                ventana.MinimizeBox = false;

                Label lblId = new Label();
                lblId.Text = "Ingrese el ID de la película:";
                lblId.Location = new Point(15, 15);
                lblId.AutoSize = true;

                TextBox txtId = new TextBox();
                txtId.Location = new Point(15, 45);
                txtId.Width = 250;

                Button btnAceptar = new Button();
                btnAceptar.Text = "Aceptar";
                btnAceptar.Location = new Point(35, 80);
                btnAceptar.DialogResult = DialogResult.OK;

                Button btnCancelar = new Button();
                btnCancelar.Text = "Cancelar";
                btnCancelar.Location = new Point(145, 80);
                btnCancelar.DialogResult = DialogResult.Cancel;

                ventana.Controls.Add(lblId);
                ventana.Controls.Add(txtId);
                ventana.Controls.Add(btnAceptar);
                ventana.Controls.Add(btnCancelar);

                ventana.AcceptButton = btnAceptar;
                ventana.CancelButton = btnCancelar;

                if (ventana.ShowDialog() != DialogResult.OK)
                    return;

                if (!int.TryParse(txtId.Text, out idPeliculaEditar))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                SqlConnection objConector = Modelo.db.conectar("LaHuesera");

                if (objConector != null)
                {
                    string sql = "SELECT nombre, descripcion, duracion, codigo " +
                                 "FROM peliculas WHERE id = " + idPeliculaEditar;

                    SqlCommand comando = new SqlCommand(sql, objConector);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        txNombre.Text = lector["nombre"].ToString();
                        txDescripcion.Text = lector["descripcion"].ToString();
                        txDuracion.Text = lector["duracion"].ToString();
                        txCodigo.Text = lector["codigo"].ToString();

                        MessageBox.Show("Película encontrada. Ahora puede modificar sus datos.",
                                        "Búsqueda exitosa",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la película.");
                    }

                    lector.Close();
                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la película: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection objConector = Modelo.db.conectar("LaHuesera");

                if (objConector != null)
                {
                    string nombre = "'" + txNombre.Text + "'";
                    string descripcion = "'" + txDescripcion.Text + "'";
                    string duracion = "'" + txDuracion.Text + "'";
                    int codigo = Int32.Parse(txCodigo.Text);

                    string sql = "UPDATE peliculas SET nombre = " + nombre +
                                 ", descripcion = " + descripcion +
                                 ", duracion = " + duracion +
                                 ", codigo = " + codigo +
                                 " WHERE id = " + idPeliculaEditar;

                    int numRegistro = Modelo.db.operar(sql, objConector);

                    if (numRegistro > 0)
                    {
                        txNombre.Clear();
                        txDescripcion.Clear();
                        txDuracion.Clear();
                        txCodigo.Clear();

                        MessageBox.Show("Película modificada correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("Problema modificando la película.");
                    }

                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar la película: " + ex.Message);
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Form ventana = new Form();
                ventana.Text = "Eliminar película";
                ventana.Size = new Size(300, 160);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
                ventana.MaximizeBox = false;
                ventana.MinimizeBox = false;

                Label lblId = new Label();
                lblId.Text = "Ingrese el ID de la película:";
                lblId.Location = new Point(15, 15);
                lblId.AutoSize = true;

                TextBox txtId = new TextBox();
                txtId.Location = new Point(15, 45);
                txtId.Width = 250;

                Button btnAceptar = new Button();
                btnAceptar.Text = "Aceptar";
                btnAceptar.Location = new Point(35, 80);
                btnAceptar.DialogResult = DialogResult.OK;

                Button btnCancelar = new Button();
                btnCancelar.Text = "Cancelar";
                btnCancelar.Location = new Point(145, 80);
                btnCancelar.DialogResult = DialogResult.Cancel;

                ventana.Controls.Add(lblId);
                ventana.Controls.Add(txtId);
                ventana.Controls.Add(btnAceptar);
                ventana.Controls.Add(btnCancelar);

                ventana.AcceptButton = btnAceptar;
                ventana.CancelButton = btnCancelar;

                if (ventana.ShowDialog() != DialogResult.OK)
                    return;

                int idPelicula;

                if (!int.TryParse(txtId.Text, out idPelicula))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                SqlConnection objConector = Modelo.db.conectar("LaHuesera");

                if (objConector != null)
                {
                    string sql = "DELETE FROM peliculas WHERE id = " + idPelicula;

                    DialogResult respuesta = MessageBox.Show(
                        "¿Está seguro de que desea eliminar esta película?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (respuesta == DialogResult.Yes)
                    {
                        int numRegistro = Modelo.db.operar(sql, objConector);

                        if (numRegistro > 0)
                        {
                            MessageBox.Show("Película eliminada correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró la película o no se pudo eliminar.");
                        }
                    }

                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la película: " + ex.Message);
            }
        }
    }
}
