
namespace Presentacion.Furnitez
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.mnsSistemaFurnitez = new System.Windows.Forms.MenuStrip();
            this.tsmiInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsminuevaVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGestionarVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSistemaFurnitez.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsSistemaFurnitez
            // 
            this.mnsSistemaFurnitez.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInicio,
            this.tsmiVentas,
            this.tsmiClientes,
            this.tsmiEmpleados,
            this.tsmiProductos,
            this.tsmiAyuda});
            this.mnsSistemaFurnitez.Location = new System.Drawing.Point(0, 0);
            this.mnsSistemaFurnitez.Name = "mnsSistemaFurnitez";
            this.mnsSistemaFurnitez.Size = new System.Drawing.Size(746, 24);
            this.mnsSistemaFurnitez.TabIndex = 4;
            this.mnsSistemaFurnitez.Text = "menuStrip1";
            // 
            // tsmiInicio
            // 
            this.tsmiInicio.Name = "tsmiInicio";
            this.tsmiInicio.Size = new System.Drawing.Size(48, 20);
            this.tsmiInicio.Text = "Inicio";
            this.tsmiInicio.Click += new System.EventHandler(this.tsmiInicio_Click);
            // 
            // tsmiVentas
            // 
            this.tsmiVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsminuevaVenta,
            this.tsmiGestionarVentas});
            this.tsmiVentas.Name = "tsmiVentas";
            this.tsmiVentas.Size = new System.Drawing.Size(53, 20);
            this.tsmiVentas.Text = "Ventas";
            this.tsmiVentas.Click += new System.EventHandler(this.tsmiVentas_Click);
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(61, 20);
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiEmpleados
            // 
            this.tsmiEmpleados.Name = "tsmiEmpleados";
            this.tsmiEmpleados.Size = new System.Drawing.Size(77, 20);
            this.tsmiEmpleados.Text = "Empleados";
            this.tsmiEmpleados.Click += new System.EventHandler(this.tsmiEmpleados_Click);
            // 
            // tsmiProductos
            // 
            this.tsmiProductos.Name = "tsmiProductos";
            this.tsmiProductos.Size = new System.Drawing.Size(73, 20);
            this.tsmiProductos.Text = "Productos";
            this.tsmiProductos.Click += new System.EventHandler(this.tsmiProductos_Click);
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(53, 20);
            this.tsmiAyuda.Text = "Ayuda";
            this.tsmiAyuda.Click += new System.EventHandler(this.tsmiAyuda_Click);
            // 
            // tsminuevaVenta
            // 
            this.tsminuevaVenta.Name = "tsminuevaVenta";
            this.tsminuevaVenta.Size = new System.Drawing.Size(180, 22);
            this.tsminuevaVenta.Text = "Nueva Venta";
            this.tsminuevaVenta.Click += new System.EventHandler(this.tsminuevaVenta_Click);
            // 
            // tsmiGestionarVentas
            // 
            this.tsmiGestionarVentas.Name = "tsmiGestionarVentas";
            this.tsmiGestionarVentas.Size = new System.Drawing.Size(180, 22);
            this.tsmiGestionarVentas.Text = "Gestionar Ventas";
            this.tsmiGestionarVentas.Click += new System.EventHandler(this.tsmiGestionarVentas_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 420);
            this.Controls.Add(this.mnsSistemaFurnitez);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsSistemaFurnitez;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA FURNITEZ";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.mnsSistemaFurnitez.ResumeLayout(false);
            this.mnsSistemaFurnitez.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnsSistemaFurnitez;
        private System.Windows.Forms.ToolStripMenuItem tsmiInicio;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmpleados;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsminuevaVenta;
        private System.Windows.Forms.ToolStripMenuItem tsmiGestionarVentas;
    }
}