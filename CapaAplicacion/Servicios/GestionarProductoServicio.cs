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
    public class GestionarProductoServicio
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private IProducto productoDAO;

        public GestionarProductoServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            productoDAO = fabricaAbstracta.crearProductoDAO(gestorAccesoDatos);
        }

        public void guardarProducto(Producto producto)
        {
            ValidarProducto validarProducto = new ValidarProducto();
            validarProducto.validarDatosDelProducto(producto);
            gestorAccesoDatos.iniciarTransaccion();
            productoDAO.guardarProducto(producto);
            gestorAccesoDatos.terminarTransaccion();
        }

        public void editarProducto(Producto producto)
        {
            ValidarProducto validarProducto = new ValidarProducto();
            gestorAccesoDatos.abrirConexion();
            validarProducto.validarDatosDelProducto(producto);
            gestorAccesoDatos.iniciarTransaccion();
            productoDAO.editarProducto(producto);
            gestorAccesoDatos.terminarTransaccion();
        }

        public List<Producto> listarProductos()
        {
            List<Producto> listaDeProductos = new List<Producto>();
            gestorAccesoDatos.iniciarTransaccion();
            listaDeProductos = productoDAO.listarProductos();
            gestorAccesoDatos.cerrarConexion();
            return listaDeProductos;
        }
        public void eliminarProducto(int idProducto)
        {
            gestorAccesoDatos.iniciarTransaccion();
            productoDAO.eliminarProducto(idProducto);
            gestorAccesoDatos.terminarTransaccion();
        }

        public Producto buscarProductoPorId(int idProducto)
        {
            gestorAccesoDatos.abrirConexion();
            Producto producto = productoDAO.buscarProductoPorId(idProducto);
            gestorAccesoDatos.cerrarConexion();
            return producto;
        }
    }
}
