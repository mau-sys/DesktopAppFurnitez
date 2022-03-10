using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Producto
    {
        //  ATRIBUTOS

        private int idProducto;
        private string nombre;
        private decimal precio;
        private int stock;
        private string tipo;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        //  REGLAS DE NEGOCIO

        public bool tieneStock(Producto producto, int cantidadRequerida)
        {
            return producto.Stock >= cantidadRequerida;
        }

        public void actualizarStock(int cantidadRequerida)
        {
            this.stock = this.stock - cantidadRequerida;
        } 

        public bool verificarNombre(string nombre)
        {
            bool verdad = true;

            if (string.IsNullOrEmpty(nombre))
            {
                verdad = false;
            }

            return verdad;
        }

        public bool verificarPrecio(decimal precio)
        {
            bool verdad = true;

            if (string.IsNullOrEmpty(Convert.ToString(precio)))
            {
                verdad = false;
            }

            return verdad;
        }

        public bool verificarRegistroDeStock(int stock)
        {
            bool verdad = true;

            if(stock < 0)
            {
                verdad = false;
            }

            return verdad;
        }

        public bool verificarTipo(string tipo)
        {
            bool verdad = true;

            if (!string.IsNullOrEmpty(tipo))
            {
                foreach (char c in tipo)
                {
                    if (char.IsDigit(c))
                    {
                        verdad = false;
                    }
                }
            }

            return verdad;
        }
    }
}
