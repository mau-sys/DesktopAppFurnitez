using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;
using CapaDominio.Entidades;
using CapaDominio.Servicios;
using CapaPersistencia.FabricaDatos;


namespace CapaAplicacion.Servicios
{
    public class GestionarEmpleadoServicio
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private IEmpleado empleadoDAO;

        public GestionarEmpleadoServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            empleadoDAO = fabricaAbstracta.crearEmpleadoDAO(gestorAccesoDatos);
        }

        public void guardarEmpleado(Empleado empleado)
        {
            ValidarEmpleado validarEmpleado = new ValidarEmpleado();
            validarEmpleado.validarDatosDelEmpleado(empleado);
            gestorAccesoDatos.iniciarTransaccion();
            empleadoDAO.guardarEmpleado(empleado);
            gestorAccesoDatos.terminarTransaccion();
        }

        public void editarEmpleado(Empleado empleado)
        {
            ValidarEmpleado validarEmpleado = new ValidarEmpleado();
            gestorAccesoDatos.abrirConexion();
            validarEmpleado.validarDatosDelEmpleado(empleado);
            gestorAccesoDatos.iniciarTransaccion();
            empleadoDAO.editarEmpleado(empleado);
            gestorAccesoDatos.terminarTransaccion();
        }

        public List<Empleado> listarEmpleados()
        {
            List<Empleado> listaDeEmpleados = new List<Empleado>();
            gestorAccesoDatos.iniciarTransaccion();
            listaDeEmpleados = empleadoDAO.listarEmpleados();
            gestorAccesoDatos.cerrarConexion();
            return listaDeEmpleados;
        }

        public Empleado bucarEmpleadoPorDni(string dni)
        {
            gestorAccesoDatos.abrirConexion();
            Empleado empleado = empleadoDAO.buscarEmpleadoPorDni(dni);
            gestorAccesoDatos.cerrarConexion();
            return empleado;
        }
    }
}
