using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IProducto
    {
        void guardarProducto(Producto producto);
        void editarProducto(Producto producto);
        List<Producto> listarProductos();
        List<Producto> buscarProductosPorNombre(string nombre);
        Producto buscarPorCodigo(int codigo);
        void eliminarProducto(int idProducto);
        Producto buscarProductoPorId(int idProducto);
    }
}
