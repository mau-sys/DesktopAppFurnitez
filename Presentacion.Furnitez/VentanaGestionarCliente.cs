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
    public partial class VentanaGestionarCliente : Form
    {
        private Cliente cliente;

        public VentanaGestionarCliente()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void VentanaGestionarCliente_Load(object sender, EventArgs e)
        {
            GestionarClienteServicio servicio = new GestionarClienteServicio();

            dgvClientes.DataSource = servicio.listarClientes();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GestionarClienteServicio servicio = new GestionarClienteServicio();

                cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Dni = txtDni.Text;
                cliente.Direccion = txtDireccion.Text;

                servicio.guardarCliente(cliente);

                MessageBox.Show(this, "Se guardó el cliente.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvClientes.DataSource = servicio.listarClientes();
                //this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Error al guardar al empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
