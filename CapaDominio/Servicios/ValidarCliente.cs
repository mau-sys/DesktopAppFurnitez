using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class ValidarCliente
    {
        public void validarDatosDelCliente(Cliente cliente)
        {
            if (cliente.verificarNombre(cliente.Nombre) == false)
            {
                throw new Exception("No se puede guardar, el nombre contiene dígitos numéricos.");
            }

            if (cliente.verificarApellido(cliente.Apellido) == false)
            {
                throw new Exception("No se puede guardar, el apellido contiene dígitos numéricos.");
            }

            if (cliente.verificarDni(cliente.Dni) == false)
            {
                throw new Exception("No se puede guardar, el dni contiene dígitos alfabéticos.");
            }
        }
    }
}
