using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDominio.Entidades
{
    public class Empleado
    {
        //  ATRIBUTOS

        private int idEmpleado;
        private string nombre;
        private string apellido;
        private string dni;
        private string contrasenia;
        private bool estado;
        //private byte[] foto;

        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public bool Estado { get => estado; set => estado = value; }
        //public byte[] Foto { get => foto; set => foto = value; }

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

            if(dni.Length == 8)
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

        public bool verificarContrasenia(string contrasenia)
        {
            bool verdad = false;

            if (contrasenia.Length == 5)
            {
                verdad = true;
            }

            return verdad;
        }

    }
}
