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
    public partial class frmStockActual : Form
    {
        private List<clsProducto> productosDisponibles;
        private List<clsProducto> productosFiltrados;
        private clsReposicion reposicion = new clsReposicion();

       
        public frmStockActual()
        {
            InitializeComponent();
            productosDisponibles = reposicion.obtenerTodosLosProductos();
            productosFiltrados = reposicion.obtenerProductoFiltrado();
            

        }


        private void frmStockActual_Load(object sender, EventArgs e)
        {
            dgvStockProductos.DataSource = null;
            dgvStockProductos.DataSource = productosDisponibles;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string nombre = txtBarraBusqueda.Text.Trim();
            string categoria = cmbCategoria.Text.Trim();

            productosFiltrados = reposicion.obtenerProductoFiltrado(nombre, categoria);

            dgvStockProductos.DataSource = productosFiltrados;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtBarraBusqueda.Text = "";
            cmbCategoria.Text = "";

            productosDisponibles = reposicion.obtenerTodosLosProductos();

            dgvStockProductos.DataSource = null;
            dgvStockProductos.DataSource = productosDisponibles;
        }


        public void refrescarGrilla()
        {
            string nombre = txtBarraBusqueda.Text.Trim();
            string categoria = cmbCategoria.Text.Trim();

            productosFiltrados = reposicion.obtenerProductoFiltrado(nombre, categoria);

            dgvStockProductos.DataSource = null;
            dgvStockProductos.DataSource = productosFiltrados;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvStockProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvStockProductos.SelectedRows[0];
                int codigoProducto = Convert.ToInt32(filaSeleccionada.Cells["Codigo"].Value);

                DialogResult resultado = MessageBox.Show("¿Estás seguro de que querés eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == resultado)
                {
                    bool eliminar = reposicion.eliminarProductoSeleccionado(codigoProducto);

                    if (eliminar)
                    {
                        MessageBox.Show("Producto eliminado correctamente");

                        refrescarGrilla();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo elimianr el producto");
                    }
                }
                else

                {
                    MessageBox.Show("Por favor, seleccioná un producto de la grilla.");
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
          

            if (dgvStockProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvStockProductos.SelectedRows[0];

                clsProducto productoSeleccionado = new clsProducto
                {
                    Codigo = Convert.ToInt32(fila.Cells["Codigo"].Value),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Categoria = fila.Cells["Categoria"].Value.ToString(),
                    Descripcion = fila.Cells["Descripcion"].Value.ToString(),
                    Precio = Convert.ToInt32(fila.Cells["Precio"].Value),
                    Cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value)
                };

                frmModificacionProducto formModificado = new frmModificacionProducto(productoSeleccionado);
                if (formModificado.ShowDialog() == DialogResult.OK)
                {
                    refrescarGrilla(); 
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un producto para modificar.");
            }

        }


    }
}
