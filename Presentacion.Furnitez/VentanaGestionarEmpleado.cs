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
using System.IO;

namespace Presentacion.Furnitez
{
    public partial class VentanaGestionarEmpleado : Form
    {
        private Empleado empleado;

        public VentanaGestionarEmpleado()
        {
            InitializeComponent();
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void VentanaListarEmpleados_Load(object sender, EventArgs e)
        {
            GestionarEmpleadoServicio servicio = new GestionarEmpleadoServicio();

            //dgvEmpleados.AutoGenerateColumns = false;
            /*
            dgvEmpleados.Columns["IdEmpleado"].DataPropertyName = "Id";
            dgvEmpleados.Columns["Nombre"].DataPropertyName = "Nombre";
            dgvEmpleados.Columns["Apellido"].DataPropertyName = "Apellido";
            dgvEmpleados.Columns["Dni"].DataPropertyName = "Dni";
            dgvEmpleados.Columns["Contrasenia"].DataPropertyName = "Contrasenia";
            dgvEmpleados.Columns["Estado"].DataPropertyName = "Estado";
            */
            //dgvEmpleados.Columns.Add("idEmpleado", "Id");
            /*
            dgvEmpleados.ColumnCount = 6;
            dgvEmpleados.Columns[0].Name = "ID";
            dgvEmpleados.Columns[1].Name = "Nombre";
            dgvEmpleados.Columns[2].Name = "Apellido";
            dgvEmpleados.Columns[3].Name = "Dni";
            dgvEmpleados.Columns[4].Name = "Contraseña";
            dgvEmpleados.Columns[5].Name = "Estado";
            */

            //desactivar esto hasta que se pueda guardar la foto
            picFotoEmpleado.Visible = false;
            btnCargarFoto.Visible = false;

            dgvEmpleados.DataSource = servicio.listarEmpleados();
        }

        private void limpiarDatos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtContrasenia.Text = "";
            chkEstado.Checked = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                GestionarEmpleadoServicio servicio = new GestionarEmpleadoServicio();

                empleado = new Empleado();
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Dni = txtDni.Text;
                empleado.Contrasenia = txtContrasenia.Text;
                empleado.Estado = chkEstado.Checked;

                //  GUARDAR LA FOTO
                /*
                empleado.Foto = Convert.ToByte(picFotoEmpleado.Image[]);
                Bitmap bmp = new Bitmap(typeof(Button, "Button.bmp");
                */
                //  VERIFICAR SI SE ESTA CREANDO O ACTUALIZANDO

                empleado.IdEmpleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);

                if (empleado.IdEmpleado > 1)
                {
                    servicio.editarEmpleado(empleado);
                    MessageBox.Show(this, "Se modificó el empleado.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarDatos();
                }
                else
                {
                    servicio.guardarEmpleado(empleado);
                    MessageBox.Show(this, "Se guardó el empleado.", "Sistema Furnitez", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarDatos();
                }

                dgvEmpleados.DataSource = servicio.listarEmpleados();
                //this.Close()
            }
            catch (Exception err)
            {
                MessageBox.Show(this, err.Message, "Error al guardar al empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            txtDni.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtContrasenia.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            chkEstado.Checked = Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells[5].Value);
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarFoto = new OpenFileDialog();
            buscarFoto.Filter = "Archivos de Imagen|*.jpg";
            buscarFoto.InitialDirectory = "D:\\";
            
            if(buscarFoto.ShowDialog() == DialogResult.OK)
            {
                string direccionDeFoto = buscarFoto.FileName;
                picFotoEmpleado.ImageLocation = buscarFoto.FileName;
                picFotoEmpleado.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
