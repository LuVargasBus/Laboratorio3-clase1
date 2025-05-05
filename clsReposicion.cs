using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace pryClase1_PetShop
{
    internal class clsReposicion
    {
        private clsConexionDB conexion = new clsConexionDB();

        public void GuardarProducto(clsProducto producto)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "INSERT INTO Productos (Nombre, Categoria, Codigo, Descripcion, Precio, Cantidad) VALUES (@nombre, @categoria, @codigo,  @descripcion,  @precio, @cantidad)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@codigo", producto.Codigo);
                    cmd.Parameters.AddWithValue("@descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool VerificarCodigoUnico(int Codigo)
        { 
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open ();
                string query = "SELECT 1 FROM Productos WHERE  Codigo = @codigo ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", Codigo);

                    
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                        return reader.HasRows;
                    }
                }
            }
        }

        public List<clsProducto> obtenerTodosLosProductos()
        {

            List<clsProducto> listaProductos = new List<clsProducto>();
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "Select Nombre, Categoria, Codigo, Descripcion, Precio, Cantidad FROM Productos;";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clsProducto producto = new clsProducto
                        {
                            Nombre = reader["Nombre"].ToString(),
                            Categoria = reader["Categoria"].ToString(),
                            Codigo = Convert.ToInt32(reader["Codigo"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            Precio = Convert.ToInt32(reader["Precio"]),
                            Cantidad = Convert.ToInt32(reader["Cantidad"])
                        };

                        listaProductos.Add(producto);
                    }
                }
                return listaProductos;
            }
        }


     
        public List<clsProducto> obtenerProductoFiltrado(string nombre = null, string categoria = null)
        {
                List<clsProducto> listaProductosFiltrados = new List<clsProducto>();
            using (SqlConnection conn = conexion.ObtenerConexion())
            { conn.Open();

                string query = "SELECT Nombre, Categoria, Codigo, Descripcion, Precio, Cantidad FROM Productos WHERE 1=1";
                if (!string.IsNullOrEmpty(nombre))
                {
                    query += " AND Nombre LIKE @Nombre";
                }

                if (!string.IsNullOrEmpty(categoria))
                {
                    query += " AND Categoria = @Categoria";
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", "%" + nombre + "%");
                    }

                    if (!string.IsNullOrEmpty(categoria))
                    {
                        cmd.Parameters.AddWithValue("@Categoria", categoria);
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsProducto producto = new clsProducto
                            {
                                Nombre = reader["Nombre"].ToString(),
                                Categoria = reader["Categoria"].ToString(),
                                Codigo = Convert.ToInt32(reader["Codigo"]),
                                Descripcion = reader["Descripcion"].ToString(),
                                Precio = Convert.ToInt32(reader["Precio"]),
                                Cantidad = Convert.ToInt32(reader["Cantidad"])
                            };

                            listaProductosFiltrados.Add(producto);
                        }
                    }
                }

                return listaProductosFiltrados;
            }

        }

        public bool eliminarProductoSeleccionado(int codigo)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string query = "DELETE FROM Productos WHERE Codigo = @Codigo";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Codigo", codigo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public bool modificarProducto(clsProducto producto)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
            conn.Open(); 
            string query = @"UPDATE Productos SET 
                         Nombre = @Nombre, 
                         Categoria = @Categoria, 
                         Descripcion = @Descripcion, 
                         Precio = @Precio, 
                         Cantidad = @Cantidad 
                         WHERE Codigo = @Codigo";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Categoria", producto.Categoria);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.Descripcion);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@Codigo", producto.Codigo);

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public List<clsProducto> controlStock(List<clsProducto> productos)
        {
            List<clsProducto> listaProductosSinStock = new List<clsProducto>();

            foreach (clsProducto producto in productos)
            {
                if (producto.Cantidad <= 1)
                {
                    listaProductosSinStock.Add(producto);
                }
            }

            return listaProductosSinStock;
        }
    }
}
