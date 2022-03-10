
namespace Presentacion.Furnitez
{
    partial class VentanaProcesarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaProcesarVenta));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpVenta = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.btnGuardarVenta = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpDocumento = new System.Windows.Forms.GroupBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCliente = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarUltimoClienteRegistrado = new System.Windows.Forms.Button();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpListado = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpVenta.SuspendLayout();
            this.grpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grpDocumento.SuspendLayout();
            this.grpCliente.SuspendLayout();
            this.tpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpVenta);
            this.tabControl1.Controls.Add(this.tpListado);
            this.tabControl1.Location = new System.Drawing.Point(12, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tpVenta
            // 
            this.tpVenta.Controls.Add(this.btnCancelar);
            this.tpVenta.Controls.Add(this.lblPrecioTotal);
            this.tpVenta.Controls.Add(this.btnGuardarVenta);
            this.tpVenta.Controls.Add(this.label10);
            this.tpVenta.Controls.Add(this.btnNuevo);
            this.tpVenta.Controls.Add(this.grpProducto);
            this.tpVenta.Controls.Add(this.grpDocumento);
            this.tpVenta.Controls.Add(this.grpCliente);
            this.tpVenta.Location = new System.Drawing.Point(4, 22);
            this.tpVenta.Name = "tpVenta";
            this.tpVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tpVenta.Size = new System.Drawing.Size(768, 425);
            this.tpVenta.TabIndex = 0;
            this.tpVenta.Text = "Venta";
            this.tpVenta.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(675, 381);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 24);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(706, 347);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(28, 13);
            this.lblPrecioTotal.TabIndex = 5;
            this.lblPrecioTotal.Text = "0.00";
            // 
            // btnGuardarVenta
            // 
            this.btnGuardarVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarVenta.Image")));
            this.btnGuardarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarVenta.Location = new System.Drawing.Point(594, 381);
            this.btnGuardarVenta.Name = "btnGuardarVenta";
            this.btnGuardarVenta.Size = new System.Drawing.Size(75, 24);
            this.btnGuardarVenta.TabIndex = 2;
            this.btnGuardarVenta.Text = "Guardar";
            this.btnGuardarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarVenta.UseVisualStyleBackColor = true;
            this.btnGuardarVenta.Click += new System.EventHandler(this.btnGuardarVenta_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total a Pagar:  S/.";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(508, 381);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 24);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.dgvProductos);
            this.grpProducto.Controls.Add(this.btnEliminarProducto);
            this.grpProducto.Controls.Add(this.btnAgregarProducto);
            this.grpProducto.Controls.Add(this.txtCantidad);
            this.grpProducto.Controls.Add(this.label6);
            this.grpProducto.Controls.Add(this.btnBuscarProducto);
            this.grpProducto.Controls.Add(this.txtNombreProducto);
            this.grpProducto.Controls.Add(this.label4);
            this.grpProducto.Location = new System.Drawing.Point(18, 128);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(736, 201);
            this.grpProducto.TabIndex = 2;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.Precio,
            this.Stock,
            this.Tipo});
            this.dgvProductos.Location = new System.Drawing.Point(14, 44);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(706, 123);
            this.dgvProductos.TabIndex = 11;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 280;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.Width = 50;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Width = 133;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProducto.Location = new System.Drawing.Point(645, 14);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 24);
            this.btnEliminarProducto.TabIndex = 10;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.Image")));
            this.btnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProducto.Location = new System.Drawing.Point(564, 14);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 24);
            this.btnAgregarProducto.TabIndex = 9;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(685, 173);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(35, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(627, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.Location = new System.Drawing.Point(535, 14);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(23, 23);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(130, 17);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(399, 20);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre del Producto:";
            // 
            // grpDocumento
            // 
            this.grpDocumento.Controls.Add(this.txtFecha);
            this.grpDocumento.Controls.Add(this.label5);
            this.grpDocumento.Controls.Add(this.txtNumeroDocumento);
            this.grpDocumento.Controls.Add(this.txtNumeroSerie);
            this.grpDocumento.Controls.Add(this.label3);
            this.grpDocumento.Controls.Add(this.label2);
            this.grpDocumento.Location = new System.Drawing.Point(329, 12);
            this.grpDocumento.Name = "grpDocumento";
            this.grpDocumento.Size = new System.Drawing.Size(425, 56);
            this.grpDocumento.TabIndex = 1;
            this.grpDocumento.TabStop = false;
            this.grpDocumento.Text = "Documento";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(345, 25);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(64, 20);
            this.txtFecha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(214, 25);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(58, 20);
            this.txtNumeroDocumento.TabIndex = 3;
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.Location = new System.Drawing.Point(56, 25);
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(32, 20);
            this.txtNumeroSerie.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "N° Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serie:";
            // 
            // grpCliente
            // 
            this.grpCliente.Controls.Add(this.btnSeleccionarUltimoClienteRegistrado);
            this.grpCliente.Controls.Add(this.txtDireccionCliente);
            this.grpCliente.Controls.Add(this.label11);
            this.grpCliente.Controls.Add(this.txtDniCliente);
            this.grpCliente.Controls.Add(this.label9);
            this.grpCliente.Controls.Add(this.btnBuscarCliente);
            this.grpCliente.Controls.Add(this.txtNombreCliente);
            this.grpCliente.Controls.Add(this.label1);
            this.grpCliente.Location = new System.Drawing.Point(18, 12);
            this.grpCliente.Name = "grpCliente";
            this.grpCliente.Size = new System.Drawing.Size(305, 110);
            this.grpCliente.TabIndex = 0;
            this.grpCliente.TabStop = false;
            this.grpCliente.Text = "Cliente";
            // 
            // btnSeleccionarUltimoClienteRegistrado
            // 
            this.btnSeleccionarUltimoClienteRegistrado.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarUltimoClienteRegistrado.Image")));
            this.btnSeleccionarUltimoClienteRegistrado.Location = new System.Drawing.Point(167, 23);
            this.btnSeleccionarUltimoClienteRegistrado.Name = "btnSeleccionarUltimoClienteRegistrado";
            this.btnSeleccionarUltimoClienteRegistrado.Size = new System.Drawing.Size(23, 23);
            this.btnSeleccionarUltimoClienteRegistrado.TabIndex = 7;
            this.btnSeleccionarUltimoClienteRegistrado.UseVisualStyleBackColor = true;
            this.btnSeleccionarUltimoClienteRegistrado.Click += new System.EventHandler(this.btnSeleccionarUltimoClienteRegistrado_Click);
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Location = new System.Drawing.Point(72, 81);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.Size = new System.Drawing.Size(217, 20);
            this.txtDireccionCliente.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Dirección:";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(72, 25);
            this.txtDniCliente.MaxLength = 8;
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(60, 20);
            this.txtDniCliente.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "D.N.I.:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.Location = new System.Drawing.Point(138, 23);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(23, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(72, 52);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(217, 20);
            this.txtNombreCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // tpListado
            // 
            this.tpListado.Controls.Add(this.dgvVentas);
            this.tpListado.Location = new System.Drawing.Point(4, 22);
            this.tpListado.Name = "tpListado";
            this.tpListado.Padding = new System.Windows.Forms.Padding(3);
            this.tpListado.Size = new System.Drawing.Size(768, 425);
            this.tpListado.TabIndex = 1;
            this.tpListado.Text = "Listado";
            this.tpListado.UseVisualStyleBackColor = true;
            this.tpListado.Click += new System.EventHandler(this.tpListado_Click);
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(20, 61);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(724, 335);
            this.dgvVentas.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(286, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 33);
            this.label7.TabIndex = 1;
            this.label7.Text = "GESTIÓN DE VENTA";
            // 
            // VentanaProcesarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 508);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Name = "VentanaProcesarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Procesar Venta";
            this.Load += new System.EventHandler(this.VentanaProcesarVenta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpVenta.ResumeLayout(false);
            this.tpVenta.PerformLayout();
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grpDocumento.ResumeLayout(false);
            this.grpDocumento.PerformLayout();
            this.grpCliente.ResumeLayout(false);
            this.grpCliente.PerformLayout();
            this.tpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpVenta;
        private System.Windows.Forms.TabPage tpListado;
        private System.Windows.Forms.GroupBox grpCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button btnSeleccionarUltimoClienteRegistrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvVentas;
    }
}