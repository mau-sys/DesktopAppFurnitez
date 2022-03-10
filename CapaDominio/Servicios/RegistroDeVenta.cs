using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class RegistroDeVenta
    {
        public void validarVenta(Venta venta, int cantidadRequerida)
        {
            if(venta.Producto.tieneStock(venta.Producto, cantidadRequerida) == false)
            {
                throw new Exception("Para guardar debe existir stock del producto.");
            }
        }
    }
}
