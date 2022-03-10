
namespace Presentacion.Furnitez
{
    partial class VentanaGestionarVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.ventaNumeroDeSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaNumeroDeDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ventaProductoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(364, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIÓN DE VENTAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvVentas);
            this.panel1.Location = new System.Drawing.Point(25, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 340);
            this.panel1.TabIndex = 1;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ventaNumeroDeSerie,
            this.ventaNumeroDeDocumento,
            this.ventaFecha,
            this.ventaTotal,
            this.ventaNombreCliente,
            this.ventaProductoNombre});
            this.dgvVentas.Location = new System.Drawing.Point(17, 18);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(893, 306);
            this.dgvVentas.TabIndex = 0;
            // 
            // ventaNumeroDeSerie
            // 
            this.ventaNumeroDeSerie.HeaderText = "N° Serie";
            this.ventaNumeroDeSerie.Name = "ventaNumeroDeSerie";
            // 
            // ventaNumeroDeDocumento
            // 
            this.ventaNumeroDeDocumento.HeaderText = "N° Documento";
            this.ventaNumeroDeDocumento.Name = "ventaNumeroDeDocumento";
            // 
            // ventaFecha
            // 
            this.ventaFecha.HeaderText = "Fecha";
            this.ventaFecha.Name = "ventaFecha";
            // 
            // ventaTotal
            // 
            this.ventaTotal.HeaderText = "Total";
            this.ventaTotal.Name = "ventaTotal";
            // 
            // ventaNombreCliente
            // 
            this.ventaNombreCliente.HeaderText = "Cliente";
            this.ventaNombreCliente.Name = "ventaNombreCliente";
            this.ventaNombreCliente.Width = 150;
            // 
            // ventaProductoNombre
            // 
            this.ventaProductoNombre.HeaderText = "Producto";
            this.ventaProductoNombre.Name = "ventaProductoNombre";
            this.ventaProductoNombre.Width = 300;
            // 
            // VentanaGestionarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "VentanaGestionarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VentanaGestionarVentas";
            this.Load += new System.EventHandler(this.VentanaGestionarVentas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaNumeroDeSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaNumeroDeDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ventaProductoNombre;
    }
}