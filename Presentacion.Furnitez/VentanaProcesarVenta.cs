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
    public partial class VentanaProcesarVenta : Form
    {
        Cliente cliente;
        private Producto producto;
        private Venta venta;

        public VentanaProcesarVenta()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void iniciarNuevaVenta()
        {
            ProcesarVentaServicio servicio = new ProcesarVentaServicio();
            int ultimoNumeroDeDocumento = servicio.obtenerUltimoNumeroDeDocumento();
            ultimoNumeroDeDocumento = ultimoNumeroDeDocumento + 1;


            //  HABILITAR TEXTBOXS Y BUTTONS

            //  Cliente
            txtDniCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            txtDireccionCliente.Enabled = true;


            btnBuscarCliente.Enabled = true;
            btnSeleccionarUltimoClienteRegistrado.Enabled = true;

            //  Documento
            txtNumeroSerie.Enabled = true;
            txtNumeroDocumento.Enabled = true;
            txtFecha.Enabled = true;


            txtNumeroSerie.ReadOnly = true;
            txtNumeroSerie.Text = "B001";
            txtNumeroDocumento.ReadOnly = true;
            txtNumeroDocumento.Text = ultimoNumeroDeDocumento.ToString();
            txtFecha.ReadOnly = true;

            //  PRODUCTO
            txtNombreProducto.Enabled = true;
            txtCantidad.Enabled = true;

            //  VENTA
            lblPrecioTotal.Text = "0.00";
            txtCantidad.Enabled = true;

            btnBuscarProducto.Enabled = true;
            btnAgregarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
            btnGuardarVenta.Enabled = true;
            btnCancelar.Enabled = true;

            //  DATOS DE FECHA
            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void ventaFinalizada()
        {
            //  Cliente
            txtDniCliente.Enabled = false;
            txtDniCliente.Text = "";
            txtNombreCliente.Enabled = false;
            txtNombreCliente.Text = "";
            txtDireccionCliente.Enabled = false;
            txtDireccionCliente.Text = "";

            btnBuscarCliente.Enabled = false;
            btnSeleccionarUltimoClienteRegistrado.Enabled = false;

            //  Documento
            txtNumeroSerie.Enabled = false;
            txtNumeroDocumento.Enabled = false;
            txtFecha.Enabled = false;

            //  PRODUCTO
            txtNombreProducto.Enabled = false;
            txtNombreProducto.Text = "";
            txtCantidad.Enabled = false;
            txtCantidad.Text = "";

            //  VENTA
            lblPrecioTotal.Text = "0.00";
            txtCantidad.Enabled = false;
            txtCantidad.Text = "";

            btnBuscarProducto.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnGuardarVenta.Enabled = false;
            btnCancelar.Enabled = false;

            //  DATAGRIDVIEW LIMPIAR FILAS
            dgvProductos.Rows.Clear();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                GestionarClienteServicio servicio = new GestionarClienteServicio();
                cliente = new Cliente();

                cliente = servicio.bucarClientePorDni(txtDniCliente.Text);

                txtNombreCliente.Text = cliente.Nombre + " " + cliente.Apellido;
                txtDireccionCliente.Text = cliente.Direccion;
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "No se encontró el cliente o no esta registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            iniciarNuevaVenta();
        }

        private void VentanaProcesarVenta_Load(object sender, EventArgs e)
        {
            //  Cliente
            txtDniCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtDireccionCliente.Enabled = false;

            btnBuscarCliente.Enabled = false;
            btnSeleccionarUltimoClienteRegistrado.Enabled = false;

            //  Documento
            txtNumeroSerie.Enabled = false;
            txtNumeroDocumento.Enabled = false;
            txtFecha.Enabled = false;

            //  PRODUCTO
            txtNombreProducto.Enabled = false;
            txtCantidad.Enabled = false;

            //  VENTA
            lblPrecioTotal.Text = "0.00";
            txtCantidad.Enabled = false;

            btnBuscarProducto.Enabled = false;
            btnAgregarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnGuardarVenta.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text.Trim();

            try
            {
                ProcesarVentaServicio servicio = new ProcesarVentaServicio();
                List<Producto> listaDeProductos = servicio.buscarProductos(nombreProducto);
                dgvProductos.Rows.Clear();
                
                foreach(Producto producto in listaDeProductos)
                {
                    Object[] filaProducto = { producto.IdProducto, producto.Nombre, producto.Precio, producto.Stock, producto.Tipo };
                    dgvProductos.Rows.Add(filaProducto);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ocurrió un problema al buscar al producto.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //int codigoProducto;
            decimal precioProducto;
            int cantidad;
            venta = new Venta();
            producto = new Producto();


            DataGridViewRow filaProducto = dgvProductos.CurrentRow;

            //  AGREGAR DATOS DEL PRODUCTO SELECCIONADO AL OBJETO PRODUCTO
            producto.IdProducto = Convert.ToInt32(filaProducto.Cells[0].Value);
            producto.Nombre = Convert.ToString(filaProducto.Cells[1].Value);
            producto.Precio = Convert.ToDecimal(filaProducto.Cells[2].Value);
            producto.Stock = Convert.ToInt32(filaProducto.Cells[3].Value);
            producto.Tipo = Convert.ToString(filaProducto.Cells[4].Value);


            try
            {
                cantidad = int.Parse(txtCantidad.Text);

                MessageBox.Show(this, "Producto Agregado.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Cantidad incorrecta, ingrese un valor entero.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            precioProducto = Convert.ToDecimal(filaProducto.Cells[2].Value);

            lblPrecioTotal.Text = Convert.ToString(venta.calcularTotalGeneral(cantidad, precioProducto));

            /*DataGridViewRow filaProducto = dgvProductos.CurrentRow;

            if(filaProducto == null)
            {
                MessageBox.Show(this, "No existe producto seleccionado.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            codigoProducto = filaProducto.Cells[0].Value.ToString();
            int codigoDelProducto = int.Parse(codigoProducto);

            //  imprimir calculo de totales
            lblPrecioTotal.Text = venta.calcularTotalGeneral().ToString();
            */
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            venta.NumeroDeSerie = txtNumeroSerie.Text;
            venta.NumeroDeDocumento = Convert.ToInt32(txtNumeroDocumento.Text);
            venta.Fecha = DateTime.Now;
            venta.Total = Convert.ToDecimal(lblPrecioTotal.Text);
            venta.Cliente = cliente;
            venta.Producto = producto;

            int cantidad = int.Parse(txtCantidad.Text);

            try
            {
                ProcesarVentaServicio servicio = new ProcesarVentaServicio();
                producto.actualizarStock(cantidad);
                servicio.guardarVenta(venta, cantidad);
                MessageBox.Show(this, "La venta ha sido registrada.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ventaFinalizada();
            }
            catch(Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                venta.Cliente = null;
                venta.Producto = null;
            }
        }

        private void btnSeleccionarUltimoClienteRegistrado_Click(object sender, EventArgs e)
        {
            try
            {
                GestionarClienteServicio servicio = new GestionarClienteServicio();
                cliente = new Cliente();

                cliente = servicio.buscarUltimoClienteRegistrado();

                txtDniCliente.Text = cliente.Dni;
                txtNombreCliente.Text = cliente.Nombre + " " + cliente.Apellido;
                txtDireccionCliente.Text = cliente.Direccion;

                //   INHABILITAR TEXTBOXS DEL CLIENTE

                txtNombreCliente.ReadOnly = true;
                txtDireccionCliente.ReadOnly = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "No se encontró al ultimo cliente registrado o no esta registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //  DATAGRIDVIEW LIMPIAR FILAS
            dgvProductos.Rows.Clear();

            // TEXTBOXS
            txtNombreProducto.Text = "";
        }

        private void tpListado_Click(object sender, EventArgs e)
        {
            //dgvVentas.DataSource = servicio.listarVentas();
            /*
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

                    Object[] filaVenta = {venta.NumeroDeSerie, venta.NumeroDeDocumento, venta.Fecha.ToString("dd/MM/yy"), venta.Total, venta.Cliente.Nombre + " " + venta.Cliente.Apellido, venta.Producto.Nombre};
                    //dgvVentas.Rows.Add(filaVenta);
                    dgvVentas.DataSource = filaVenta;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Ocurrió un problema al listar las ventas.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }
    }
}
