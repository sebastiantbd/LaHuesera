using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioLaHuesera.Modelo
{
    public class db
    {
        public static SqlConnection conectar(string nomBD)
        {
            SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial " +
            "Catalog = " + nomBD + "; Integrated Security = SSPI; ");
            try
            {
                objConectar.Open();
                MessageBox.Show("Se realizo la conexion...");
                return objConectar;
            }
            catch
                (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }
        public static SqlDataReader consulta(string conSQL,
       SqlConnection objConector)
        {
            try
            {
                SqlCommand objComando = new SqlCommand(conSQL, objConector);
                SqlDataReader tabla = objComando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }
        public static int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                SqlCommand objComando = new SqlCommand(conSQL, conector);
                num = objComando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Fallo la consulta" + e.ToString()); return
                num;
            }
        }
        public static void cerrar(SqlConnection objConector)
        {
            try
            {
                objConector.Close();
            }
            catch (SqlException eq) { }
        }
    }
}
