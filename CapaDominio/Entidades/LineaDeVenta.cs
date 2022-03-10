using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class LineaDeVenta
    {
        //  ATRIBUTOS

        private int idLineaDeVenta;
        private int cantidad;
        private decimal precio;
        private Producto producto;

        public int IdLineaDeVenta { get => idLineaDeVenta; set => idLineaDeVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public Producto Producto { get => producto; set => producto = value; }

        //  CONSTRUCTOR

        public LineaDeVenta(int cantidad, Producto producto)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            precio = producto.Precio;
        }

        //  REGLAS DE NEGOCIO

        public decimal calcularTotal()
        {
            return cantidad * precio;
        }

        public void actualizarStock()
        {
            int stockActualizado = producto.Stock - cantidad;
            producto.Stock = stockActualizado;
        }

    }
}
