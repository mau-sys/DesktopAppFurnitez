using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;

namespace CapaPersistencia.FabricaDatos
{
    public abstract class FabricaAbstracta
    {
        public static FabricaAbstracta crearInstancia()
        {
            return new FabricaSqlServer();
        }

        public abstract IGestorAccesoDatos crearGestorAccesoDatos();
        public abstract IEmpleado crearEmpleadoDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract ICliente crearClienteDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IProducto crearProductoDAO(IGestorAccesoDatos gestorAccesoDatos);
        public abstract IVenta crearVentaDAO(IGestorAccesoDatos gestorAccesoDatos);

    }
}
