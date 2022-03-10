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
    public class ProcesarVentaServicio
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private IEmpleado empleadoDAO;
        private ICliente clienteDAO;
        private IProducto productoDAO;
        private IVenta ventaDAO;

        public ProcesarVentaServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            empleadoDAO = fabricaAbstracta.crearEmpleadoDAO(gestorAccesoDatos);
            productoDAO = fabricaAbstracta.crearProductoDAO(gestorAccesoDatos);
            clienteDAO = fabricaAbstracta.crearClienteDAO(gestorAccesoDatos);
            ventaDAO = fabricaAbstracta.crearVentaDAO(gestorAccesoDatos);
        }

        public List<Producto> buscarProductos(string nombre)
        {
            gestorAccesoDatos.abrirConexion();
            List<Producto> listaDeProductos = productoDAO.buscarProductosPorNombre(nombre);
            gestorAccesoDatos.cerrarConexion();
            return listaDeProductos;
        }

        public Cliente buscarCliente(string dni)
        {
            gestorAccesoDatos.abrirConexion();
            Cliente cliente = clienteDAO.buscarClientePorDni(dni);
            gestorAccesoDatos.cerrarConexion();
            return cliente;
        }

        public int obtenerUltimoNumeroDeDocumento()
        {
            gestorAccesoDatos.abrirConexion();
            int ultimoNumeroDeDocumento = ventaDAO.obtenerUltimoNumeroDeDocumento();
            gestorAccesoDatos.cerrarConexion();
            return ultimoNumeroDeDocumento;
        }

        public void guardarVenta(Venta venta, int cantidadRequerida)
        {
            RegistroDeVenta registroDeVenta = new RegistroDeVenta();
            registroDeVenta.validarVenta(venta, cantidadRequerida);
            gestorAccesoDatos.iniciarTransaccion();
            ventaDAO.guardar(venta);
            gestorAccesoDatos.terminarTransaccion();
        }
    }
}
