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
    public partial class VentanaInicioDeSesion : Form
    {
        private Empleado empleadoSesionActual;
        private const string dniGerente = "43615637";

        public VentanaInicioDeSesion()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtUsuario.Text.Trim();
            string contrasenia = txtContrasenia.Text.Trim();

            try
            {
                GestionarEmpleadoServicio servicio = new GestionarEmpleadoServicio();
                empleadoSesionActual = servicio.bucarEmpleadoPorDni(dni);

                if(dni == dniGerente && contrasenia == empleadoSesionActual.Contrasenia)
                {
                    VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                    ventanaPrincipal.empleadoSesionActual = empleadoSesionActual;
                    ventanaPrincipal.Show();
                    this.Hide();
                }
                else if(empleadoSesionActual.Dni == dni && empleadoSesionActual.Contrasenia == contrasenia)
                {
                    VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
                    ventanaPrincipal.empleadoSesionActual = empleadoSesionActual;
                    ventanaPrincipal.Show();
                    this.Hide();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empleadoSesionActual = null;
            }
        }
    }
}
