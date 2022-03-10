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
    public partial class VentanaPrincipal : Form
    {
        public Empleado empleadoSesionActual;

        public VentanaPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;
            MaximizeBox = false;
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            VentanaGestionarEmpleado ventanaGestionarEmpleado = new VentanaGestionarEmpleado();
            ventanaGestionarEmpleado.Show();
            //this.Hide();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            VentanaGestionarCliente ventanaGestionarCliente = new VentanaGestionarCliente();
            ventanaGestionarCliente.Show();
            //this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            VentanaGestionarProducto ventanaGestionarProducto = new VentanaGestionarProducto();
            ventanaGestionarProducto.Show();
        }

        private void tsmiClientes_Click(object sender, EventArgs e)
        {
            VentanaGestionarCliente ventanaGestionarCliente = new VentanaGestionarCliente();
            ventanaGestionarCliente.MdiParent = this;
            //this.Size = new System.Drawing.Size(816, 489);
            this.Size = new System.Drawing.Size(ventanaGestionarCliente.Size.Width, ventanaGestionarCliente.Size.Height + 30);
            ventanaGestionarCliente.Show();
            ventanaGestionarCliente.WindowState = FormWindowState.Maximized;

            //tsmiClientes.Enabled = false;
            
        }

        private void tsmiVentas_Click(object sender, EventArgs e)
        {/*
            VentanaProcesarVenta ventanaProcesarVenta = new VentanaProcesarVenta();
            ventanaProcesarVenta.MdiParent = this;
            this.Size = new Size(ventanaProcesarVenta.Size.Width, ventanaProcesarVenta.Size.Height + 30);
            ventanaProcesarVenta.Show();
            ventanaProcesarVenta.WindowState = FormWindowState.Maximized;
            */
            //tsmiVentas.Enabled = false;
        }

        private void tsmiEmpleados_Click(object sender, EventArgs e)
        {
            VentanaGestionarEmpleado ventanaGestionarEmpleado = new VentanaGestionarEmpleado();
            ventanaGestionarEmpleado.MdiParent = this;
            this.Size = new Size(ventanaGestionarEmpleado.Size.Width, ventanaGestionarEmpleado.Size.Height + 30);
            ventanaGestionarEmpleado.Show();
            ventanaGestionarEmpleado.WindowState = FormWindowState.Maximized;

            //tsmiEmpleados.Enabled = false;
        }

        private void tsmiProductos_Click(object sender, EventArgs e)
        {
            VentanaGestionarProducto ventanaGestionarProducto = new VentanaGestionarProducto();
            ventanaGestionarProducto.MdiParent = this;
            this.Size = new Size(ventanaGestionarProducto.Size.Width, ventanaGestionarProducto.Size.Height + 30);
            ventanaGestionarProducto.Show();
            ventanaGestionarProducto.WindowState = FormWindowState.Maximized;

            //tsmiEmpleados.Enabled = false;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            VentanaInicio ventanaInicio = new VentanaInicio();
            ventanaInicio.MdiParent = this;
            this.Size = new Size(ventanaInicio.Size.Width, ventanaInicio.Size.Height + 30);
            ventanaInicio.empleadoSesionActual = empleadoSesionActual;
            ventanaInicio.Show();
            ventanaInicio.WindowState = FormWindowState.Maximized;
        }

        private void tsmiInicio_Click(object sender, EventArgs e)
        {
            VentanaInicio ventanaInicio = new VentanaInicio();
            ventanaInicio.MdiParent = this;
            this.Size = new Size(ventanaInicio.Size.Width, ventanaInicio.Size.Height + 30);
            ventanaInicio.empleadoSesionActual = empleadoSesionActual;
            ventanaInicio.Show();
            ventanaInicio.WindowState = FormWindowState.Maximized;
        }

        private void tsmiAyuda_Click(object sender, EventArgs e)
        {
            VentanaAyuda ventanaAyuda = new VentanaAyuda();
            ventanaAyuda.MdiParent = this;
            this.Size = new Size(ventanaAyuda.Size.Width, ventanaAyuda.Size.Height + 30);
            ventanaAyuda.Show();
            ventanaAyuda.WindowState = FormWindowState.Maximized;
        }

        private void tsminuevaVenta_Click(object sender, EventArgs e)
        {
            VentanaProcesarVenta ventanaProcesarVenta = new VentanaProcesarVenta();
            ventanaProcesarVenta.MdiParent = this;
            this.Size = new Size(ventanaProcesarVenta.Size.Width, ventanaProcesarVenta.Size.Height + 30);
            ventanaProcesarVenta.Show();
            ventanaProcesarVenta.WindowState = FormWindowState.Maximized;
        }

        private void tsmiGestionarVentas_Click(object sender, EventArgs e)
        {
            VentanaGestionarVentas ventanaGestionarVentas = new VentanaGestionarVentas();
            ventanaGestionarVentas.MdiParent = this;
            this.Size = new Size(ventanaGestionarVentas.Size.Width, ventanaGestionarVentas.Size.Height + 30);
            ventanaGestionarVentas.Show();
            ventanaGestionarVentas.WindowState = FormWindowState.Maximized;
        }
    }
}
