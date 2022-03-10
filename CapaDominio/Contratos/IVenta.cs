using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IVenta
    {
        void guardar(Venta venta);
        List<Venta> listarVentas();
        int obtenerUltimoNumeroDeDocumento();
    }
}
