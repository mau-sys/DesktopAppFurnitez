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
    public class GestionarVentaServicio
    {
        private IGestorAccesoDatos gestorAccesoDatos;
        private IVenta ventaDAO;

        public GestionarVentaServicio()
        {
            FabricaAbstracta fabricaAbstracta = FabricaAbstracta.crearInstancia();
            gestorAccesoDatos = fabricaAbstracta.crearGestorAccesoDatos();
            ventaDAO = fabricaAbstracta.crearVentaDAO(gestorAccesoDatos);
        }

        public List<Venta> listarVentas()
        {
            List<Venta> listaDeVentas = new List<Venta>();
            gestorAccesoDatos.iniciarTransaccion();
            listaDeVentas = ventaDAO.listarVentas();
            gestorAccesoDatos.cerrarConexion();
            return listaDeVentas;
        }
    }
}
