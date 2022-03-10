using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Venta
    {
        //  ATRIBUTOS

        private int idVenta;
        private string numeroDeSerie;
        private int numeroDeDocumento;
        private DateTime fecha;
        private decimal total;
        private Cliente cliente;
        private Producto producto;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
        public int NumeroDeDocumento { get => numeroDeDocumento; set => numeroDeDocumento = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public decimal Total { get => total; set => total = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Producto Producto { get => producto; set => producto = value; }

        //  REGLAS DE NEGOCIO

        public decimal calcularTotalGeneral(int cantidad, decimal precio)
        {
            decimal total = cantidad * precio;

            return total;
        }
        
    }
}
