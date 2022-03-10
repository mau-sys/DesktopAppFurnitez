using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Cliente
    {
        //  ATRIBUTOS

        private int idCliente;
        private string dni;
        private string nombre;
        private string apellido;
        private string direccion;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        //  REGLAS DE NEGOCIO

        public bool verificarNombre(string nombre)
        {
            bool verdad = true;

            foreach (char c in nombre)
            {
                if (char.IsDigit(c))
                {
                    verdad = false;
                }
            }

            return verdad;
        }

        public bool verificarApellido(string apellido)
        {
            bool verdad = true;

            foreach (char c in apellido)
            {
                if (char.IsDigit(c))
                {
                    verdad = false;
                }
            }

            return verdad;
        }

        public bool verificarDni(string dni)
        {
            bool verdad = false;

            if (dni.Length == 8)
            {
                foreach (char c in dni)
                {
                    if (!char.IsDigit(c))
                    {
                        verdad = false;
                    }
                }
                verdad = true;
            }

            return verdad;
        }
    }
}
