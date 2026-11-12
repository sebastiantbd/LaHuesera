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
    public partial class GestionUsuario : Form
    {
        public GestionUsuario()
        {
            InitializeComponent();
        }
        private int idUsuarioEditar;
        private int idUsuarioBuscar;
        private void btAgregarUsuario_Click(object sender, EventArgs e)
        {
            SqlConnection objConector = Modelo.db.conectar("LaHuesera");
            if (objConector != null)
            {
                string nombre = "'" + txNombre.Text + "'";
                string clave = "'" + txClave.Text + "'";
                string rol = "'" + cbRol.SelectedValue + "'";

                string sql = "insert into usuarios values(" +
                    nombre + "," + clave + "," + rol + ")";
                int numRegistro = Modelo.db.operar(sql, objConector);
                if (numRegistro > 0)
                {
                    txNombre.Clear();
                    txClave.Clear();
                    cbRol.SelectedIndex = -1;
                    MessageBox.Show("Usuario creado");
                }
                else
                {
                    MessageBox.Show("Problema agregando usuario");
                }

            }

        }

        private void btEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Form ventana = new Form();
                ventana.Text = "Buscar usuario a editar";
                ventana.Size = new Size(300, 160);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
                ventana.MaximizeBox = false;
                ventana.MinimizeBox = false;

                Label lblId = new Label();
                lblId.Text = "Ingrese el ID del usuario:";
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

                if (!int.TryParse(txtId.Text, out idUsuarioEditar))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                SqlConnection objConector = Modelo.db.conectar("LaHuesera");

                if (objConector != null)
                {
                    string sql = "SELECT nombre, clave, rol " +
                                 "FROM usuarios WHERE id = " + idUsuarioEditar;

                    SqlCommand comando = new SqlCommand(sql, objConector);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        txNombre.Text = lector["nombre"].ToString();
                        txClave.Text = lector["clave"].ToString();
                        cbRol.SelectedValue = lector["rol"].ToString();

                        MessageBox.Show("Usuario encontrado. Ahora puede modificar sus datos.",
                                        "Búsqueda exitosa",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }

                    lector.Close();
                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btConsultarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                Form ventana = new Form();
                ventana.Text = "Buscar usuario a editar";
                ventana.Size = new Size(300, 160);
                ventana.StartPosition = FormStartPosition.CenterParent;
                ventana.FormBorderStyle = FormBorderStyle.FixedDialog;
                ventana.MaximizeBox = false;
                ventana.MinimizeBox = false;

                Label lblId = new Label();
                lblId.Text = "Ingrese el ID del usuario:";
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

                if (!int.TryParse(txtId.Text, out idUsuarioBuscar))
                {
                    MessageBox.Show("Ingrese un ID válido.");
                    return;
                }

                SqlConnection objConector = Modelo.db.conectar("LaHuesera");

                if (objConector != null)
                {
                    string sql = "SELECT nombre, clave, rol " +
                                 "FROM usuarios WHERE id = " + idUsuarioBuscar;

                    SqlCommand comando = new SqlCommand(sql, objConector);

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read())
                    {
                        txNombre.Text = lector["nombre"].ToString();
                        txClave.Text = lector["clave"].ToString();
                        cbRol.SelectedValue = lector["rol"].ToString();

                        MessageBox.Show("Usuario encontrado. Ahora puede ver sus datos.",
                                        "Búsqueda exitosa",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el usuario.");
                    }

                    lector.Close();
                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message,
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
                    string clave = "'" + txClave.Text + "'";
                    string rol = "'" + cbRol.SelectedValue + "'";

                    string sql = "UPDATE usuarios SET nombre = " + nombre +
                                 ", clave = " + clave +
                                 ", rol = " + rol +
                                 " WHERE id = " + idUsuarioBuscar;

                    int numRegistro = Modelo.db.operar(sql, objConector);

                    if (numRegistro > 0)
                    {
                        txNombre.Clear();
                        txClave.Clear();
                        cbRol.SelectedIndex = -1;

                        MessageBox.Show("Usuario modificado correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("Problema modificando el usuario.");
                    }

                    objConector.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el usuario: " + ex.Message);
            }
        }
    }
}
