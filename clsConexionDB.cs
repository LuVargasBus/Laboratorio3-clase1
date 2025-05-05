using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace pryClase1_PetShop
{
    internal class clsConexionDB
    {

        string connectionString = "Server=localhost;Database=PetShop;Trusted_Connection=True;";
        private SqlConnection conn;
        public clsConexionDB()
        {
            
                conn = new SqlConnection(connectionString);
            
        }
        public void AbrirConexion()
        {
            try
            {

                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");

                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error al conectar: " + ex.Message);

            }
        }
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(connectionString);
        }

    }
}

