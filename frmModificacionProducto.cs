using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClase1_PetShop
{
    public partial class frmModificacionProducto : Form
    {
        private clsReposicion reposicion = new clsReposicion();
        private clsProducto productoActual;

        public frmModificacionProducto(clsProducto producto)
        {
            InitializeComponent();
            productoActual = producto; 
            
        }

        private void frmModificacionProducto_Load(object sender, EventArgs e)
        {
            txtNombreModificado.Text = productoActual.Nombre;
            cmbCategoriaModificada.Text = productoActual.Categoria;
            txtCodigoModificado.Text = productoActual.Codigo.ToString();
            txtDescripcionModificada.Text = productoActual.Descripcion;
            txtPrecioModificado.Text = productoActual.Precio.ToString();
            txtCantidadModificada.Text = productoActual.Cantidad.ToString();

            txtCodigoModificado.ReadOnly = true; 

        }



      
        private void btnVerStock_Click(object sender, EventArgs e)
        { 
            
                frmStockActual verProductos = new frmStockActual();
                verProductos.Show();
           
        }

        private void btnGuardarModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                productoActual.Nombre = txtNombreModificado.Text;
                productoActual.Categoria = cmbCategoriaModificada.Text;
                productoActual.Descripcion = txtDescripcionModificada.Text;
                productoActual.Precio = int.Parse(txtPrecioModificado.Text);
                productoActual.Cantidad = int.Parse(txtCantidadModificada.Text);

                bool actualizado = reposicion.modificarProducto(productoActual);

                if (actualizado)
                {
                    MessageBox.Show("Producto modificado correctamente.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }
    }
}

