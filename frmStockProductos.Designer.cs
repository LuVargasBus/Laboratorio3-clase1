namespace pryClase1_PetShop
{
    partial class frmStockActual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStockProductos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBarraBusqueda = new System.Windows.Forms.TextBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lstViewStock = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockProductos
            // 
            this.dgvStockProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockProductos.Location = new System.Drawing.Point(53, 375);
            this.dgvStockProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStockProductos.Name = "dgvStockProductos";
            this.dgvStockProductos.RowHeadersWidth = 51;
            this.dgvStockProductos.Size = new System.Drawing.Size(892, 188);
            this.dgvStockProductos.TabIndex = 0;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(645, 599);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 37);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(814, 599);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(132, 37);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(237, 243);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 38);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBarraBusqueda
            // 
            this.txtBarraBusqueda.Location = new System.Drawing.Point(53, 88);
            this.txtBarraBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarraBusqueda.Name = "txtBarraBusqueda";
            this.txtBarraBusqueda.Size = new System.Drawing.Size(481, 22);
            this.txtBarraBusqueda.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Enabled = false;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Alimento",
            "Camas y cuchas",
            "Collares y correas",
            "Higiene y cuidado",
            "Juguetes",
            "Medicamentos"});
            this.cmbCategoria.Location = new System.Drawing.Point(53, 185);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(481, 24);
            this.cmbCategoria.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar por categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar por producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Productos";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(394, 243);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(140, 38);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(575, 39);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(158, 16);
            this.lblStock.TabIndex = 11;
            this.lblStock.Text = "Productos con bajo stock";
            // 
            // lstViewStock
            // 
            this.lstViewStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Cantidad});
            this.lstViewStock.HideSelection = false;
            this.lstViewStock.Location = new System.Drawing.Point(578, 88);
            this.lstViewStock.Name = "lstViewStock";
            this.lstViewStock.Size = new System.Drawing.Size(367, 193);
            this.lstViewStock.TabIndex = 12;
            this.lstViewStock.UseCompatibleStateImageBehavior = false;
            // 
            // frmStockActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 667);
            this.Controls.Add(this.lstViewStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.txtBarraBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dgvStockProductos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockActual";
            this.Text = "Stock actual";
            this.Load += new System.EventHandler(this.frmStockActual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockProductos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBarraBusqueda;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.ListView lstViewStock;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Cantidad;
    }
}