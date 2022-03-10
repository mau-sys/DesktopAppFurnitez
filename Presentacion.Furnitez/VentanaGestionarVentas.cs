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
    public partial class VentanaGestionarVentas : Form
    {
        public VentanaGestionarVentas()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void VentanaGestionarVentas_Load(object sender, EventArgs e)
        {
            try
            {
                GestionarVentaServicio servicioVenta = new GestionarVentaServicio();
                GestionarClienteServicio servicioCliente = new GestionarClienteServicio();
                GestionarProductoServicio servicioProducto = new GestionarProductoServicio();

                Cliente cliente = new Cliente();
                Producto producto = new Producto();

                List<Venta> listaDeVentas = servicioVenta.listarVentas();

                foreach (Venta venta in listaDeVentas)
                {
                    venta.Cliente = servicioCliente.buscarClientePorId(venta.Cliente.IdCliente);
                    venta.Producto = servicioProducto.buscarProductoPorId(venta.Producto.IdProducto);

                    Object[] filaVenta = { venta.NumeroDeSerie, venta.NumeroDeDocumento, venta.Fecha.ToString("dd/MM/yy"), venta.Total, venta.Cliente.Nombre + " " + venta.Cliente.Apellido, venta.Producto.Nombre };
                    dgvVentas.Rows.Add(filaVenta);
                    //dgvVentas.DataSource = filaVenta;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ocurrió un problema al listar las ventas.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
