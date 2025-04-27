using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClase1_PetShop
{
    public partial class frmCargaProductos : Form
    {
        private clsReposicion reposicion = new clsReposicion();
        public frmCargaProductos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clsProducto nuevoProducto = new clsProducto
                {
                    Nombre = txtNombreProducto.Text,
                    Categoria = cmbCategoriaProductos.Text,
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Descripcion = txtDescripcion.Text,
                    Precio = Convert.ToInt32(txtPrecio.Text),
                    Cantidad = Convert.ToInt32(txtCantidad.Text),
                };
                reposicion.GuardarProducto(nuevoProducto);
                MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar guardar", "Error" ,  MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnVerStock_Click(object sender, EventArgs e)
        {
            frmStockActual verProductos = new frmStockActual();
            verProductos.Show();
        }

        
    }
}
