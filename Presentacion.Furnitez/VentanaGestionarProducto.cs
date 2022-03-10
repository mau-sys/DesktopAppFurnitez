using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaAplicacion.Servicios;
using CapaDominio.Entidades;

namespace Presentacion.Furnitez
{
    public partial class VentanaGestionarProducto : Form
    {
        private Producto producto = new Producto();

        public VentanaGestionarProducto()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void limpiarDatos()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtTipo.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GestionarProductoServicio servicio = new GestionarProductoServicio();

                //producto = new Producto();

                //dgvProductos.ClearSelection();
                //dgvProductos.CurrentCell = null;

                producto.Nombre = txtNombre.Text;
                producto.Precio = Convert.ToDecimal(txtPrecio.Text);
                producto.Stock = Convert.ToInt32(txtStock.Text);
                producto.Tipo = txtTipo.Text;



                //  VERIFICAR SI SE ESTA CREANDO O ACTUALIZANDO

                //producto.IdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                if (producto.IdProducto >= 1)
                {
                    servicio.editarProducto(producto);
                    MessageBox.Show(this, "Se modificó el producto.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarDatos();
                }
                else
                {
                    servicio.guardarProducto(producto);
                    MessageBox.Show(this, "Se guardó el producto.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarDatos();
                }

                dgvProductos.DataSource = servicio.listarProductos();
                //this.Close()
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Error al guardar al producto", MessageBoxButtons.OK, MessageBoxIcon.Error);

                limpiarDatos();
            }
        }

        private void VentanaGestionarProducto_Load(object sender, EventArgs e)
        {
            GestionarProductoServicio servicio = new GestionarProductoServicio();
            dgvProductos.DataSource = servicio.listarProductos();
            dgvProductos.ClearSelection();
            dgvProductos.CurrentCell = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtPrecio.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txtTipo.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();

            //  ASIGNAR DATOS DE LA FILA AL PRODUCTO

            producto.IdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                GestionarProductoServicio servicio = new GestionarProductoServicio();

                producto.IdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

                servicio.eliminarProducto(producto.IdProducto);

                MessageBox.Show(this, "Se eliminó el producto.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvProductos.DataSource = servicio.listarProductos();

                producto.IdProducto = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Error al eliminar al producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
