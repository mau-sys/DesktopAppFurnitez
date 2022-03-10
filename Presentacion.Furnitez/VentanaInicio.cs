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
    public partial class VentanaInicio : Form
    {
        public Empleado empleadoSesionActual;

        public VentanaInicio()
        {
            InitializeComponent();
            MaximizeBox = false;
            //ControlBox = false;
        }

        private void VentanaInicio_Load(object sender, EventArgs e)
        {
            lblNombre.Text = empleadoSesionActual.Nombre;
            lblApellido.Text = empleadoSesionActual.Apellido;
            lblDni.Text = empleadoSesionActual.Dni;

            lblFechaYHora.Text = DateTime.Now.ToLongDateString() + " || " + DateTime.Now.ToString("hh:mm tt");
        }
    }
}
