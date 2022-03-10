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
    public class GestionarClienteServicio
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private ICliente clienteDAO;

        public GestionarClienteServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            clienteDAO = fabricaAbstracta.crearClienteDAO(gestorAccesoDatos);
        }

        public void guardarCliente(Cliente cliente)
        {
            ValidarCliente validarCliente = new ValidarCliente();
            validarCliente.validarDatosDelCliente(cliente);
            gestorAccesoDatos.iniciarTransaccion();
            clienteDAO.guardarCliente(cliente);
            gestorAccesoDatos.terminarTransaccion();
        }

        public void editarCliente(Cliente cliente)
        {
            ValidarCliente validarCliente = new ValidarCliente();
            gestorAccesoDatos.abrirConexion();
            validarCliente.validarDatosDelCliente(cliente);
            gestorAccesoDatos.iniciarTransaccion();
            clienteDAO.editarCliente(cliente);
            gestorAccesoDatos.terminarTransaccion();
        }

        public List<Cliente> listarClientes()
        {
            List<Cliente> listaDeClientes = new List<Cliente>();
            gestorAccesoDatos.iniciarTransaccion();
            listaDeClientes = clienteDAO.listarClientes();
            gestorAccesoDatos.cerrarConexion();
            return listaDeClientes;
        }

        public Cliente bucarClientePorDni(string dni)
        {
            gestorAccesoDatos.abrirConexion();
            Cliente cliente = clienteDAO.buscarClientePorDni(dni);
            gestorAccesoDatos.cerrarConexion();
            return cliente;
        }

        public Cliente buscarUltimoClienteRegistrado()
        {
            gestorAccesoDatos.abrirConexion();
            Cliente cliente = clienteDAO.seleccionarUltimoClienteRegistrado();
            gestorAccesoDatos.cerrarConexion();
            return cliente;
        }

        public Cliente buscarClientePorId(int idCliente)
        {
            gestorAccesoDatos.abrirConexion();
            Cliente cliente = clienteDAO.buscarClientePorId(idCliente);
            gestorAccesoDatos.cerrarConexion();
            return cliente;
        }
    }
}
