using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;
using CapaPersistencia.ADO_SqlServer;


namespace CapaPersistencia.FabricaDatos
{
    public class FabricaSqlServer : FabricaAbstracta
    {
        public override IGestorAccesoDatos crearGestorAccesoDatos()
        {
            return new GestorSQL();
        }

        public override IEmpleado crearEmpleadoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new EmpleadoDAO(gestorAccesoDatos);
        }

        public override ICliente crearClienteDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ClienteDAO(gestorAccesoDatos);
        }

        public override IProducto crearProductoDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new ProductoDAO(gestorAccesoDatos);
        }

        public override IVenta crearVentaDAO(IGestorAccesoDatos gestorAccesoDatos)
        {
            return new VentaDAO(gestorAccesoDatos);
        }

    }
}
