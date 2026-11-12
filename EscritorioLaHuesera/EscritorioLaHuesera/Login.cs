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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btEnviar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txUsuario.Text) ||
                String.IsNullOrEmpty(txClave.Text))
            {
                MessageBox.Show("Debe ingresar toda la informacion.");
            }
            else
            {
                SqlConnection objConector = Modelo.db.conectar("LaHuesera");
                string sql = ("Select * from usuarios where " +
                    "nombre ='" + txUsuario.Text + "'");
                SqlDataReader objTabla = Modelo.db.consulta(sql, objConector);
                if (objTabla.Read())
                {
                    string claveDb = objTabla[2].ToString();
                    if (claveDb == txClave.Text)
                    {
                        MessageBox.Show("Bienvenido " + txUsuario.Text);
                        string rol = objTabla[3].ToString();
                        this.Hide();
                        MunuLaHuesera objMenu = new MunuLaHuesera(rol, this);
                        objMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show(txUsuario.Text + " " + claveDb);
                        MessageBox.Show("Usuario o clave incorrectos");
                        txUsuario.Clear();
                        txClave.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Error en el usuario o clave");
                }
            }

        }
    }
}
