using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class ValidarProducto
    {
        public void validarDatosDelProducto(Producto producto)
        {
            if(producto.verificarNombre(producto.Nombre) == false)
            {
                throw new Exception("No se puede guardar, el nombre del producto no contiene datos.");
            }

            if(producto.verificarPrecio(producto.Precio) == false)
            {
                throw new Exception("No se puede guardar, el precio del producto no contiene datos.");
            }

            if(producto.verificarRegistroDeStock(producto.Stock) == false)
            {
                throw new Exception("No se puede guardar, el stock del producto debe ser mayor igual a cero.");
            }

            if(producto.verificarTipo(producto.Tipo) == false)
            {
                throw new Exception("No se puede guardar, el tipo del producto deben ser letras o contener datos.");
            }
        }
    }
}
