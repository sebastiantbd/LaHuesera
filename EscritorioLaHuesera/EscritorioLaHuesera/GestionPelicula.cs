using EscritorioLaHuesera.dbApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EscritorioLaHuesera
{
    public partial class GestionPelicula : Form
    {
        public GestionPelicula()
        {
            InitializeComponent();
        }

        private int idPeliculaEditar;

        private string urlApi = "https://localhost:44379/api/Peliculas";

        private void btAgregarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula pelicula = new Pelicula();

                pelicula.Nombre = txNombre.Text;
                pelicula.Descripcion = txDescripcion.Text;
                pelicula.Duracion = txDuracion.Text;
                pelicula.Codigo = int.Parse(txCodigo.Text);

                dynamic respuesta = DBApi.Post(urlApi, pelicula);

                MessageBox.Show("Película agregada exitosamente.",
                                "Registro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la película: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
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
            dynamic respuesta = dbApi.DBApi.Get(urlApi);
            txSalida.Text = respuesta.ToString();
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

                dynamic respuesta = DBApi.Get(urlApi + "/" + idPeliculaEditar);

                if (respuesta == null)
                {
                    MessageBox.Show("No se encontró la película.");
                    return;
                }

                txNombre.Text = respuesta.nombre;
                txDescripcion.Text = respuesta.descripcion;
                txDuracion.Text = respuesta.duracion;
                txCodigo.Text = respuesta.codigo.ToString();

                MessageBox.Show("Película encontrada. Ahora puede modificar sus datos.",
                                "Búsqueda exitosa",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
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
                if (idPeliculaEditar <= 0)
                {
                    MessageBox.Show("Primero debe buscar una película.");
                    return;
                }

                Pelicula pelicula = new Pelicula();

                pelicula.Id = idPeliculaEditar;
                pelicula.Nombre = txNombre.Text;
                pelicula.Descripcion = txDescripcion.Text;
                pelicula.Duracion = txDuracion.Text;
                pelicula.Codigo = int.Parse(txCodigo.Text);

                dynamic respuesta = DBApi.Put(urlApi + "/" + idPeliculaEditar, pelicula);

                MessageBox.Show("Película actualizada exitosamente.",
                                "Actualización",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                idPeliculaEditar = 0;
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar la película: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}
