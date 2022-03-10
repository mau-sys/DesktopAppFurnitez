using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Servicios
{
    public class ValidarEmpleado
    {
        public void validarDatosDelEmpleado(Empleado empleado)
        {
            if(empleado.verificarNombre(empleado.Nombre) == false)
            {
                throw new Exception("No se puede guardar, el nombre contiene dígitos numéricos.");
            }

            if(empleado.verificarApellido(empleado.Apellido) == false)
            {
                throw new Exception("No se puede guardar, el apellido contiene dígitos numéricos.");
            }

            if(empleado.verificarDni(empleado.Dni) == false)
            {
                throw new Exception("No se puede guardar, el dni contiene dígitos alfabéticos.");
            }
            
            if(empleado.verificarContrasenia(empleado.Contrasenia) == false)
            {
                throw new Exception("No se puede guardar, la contrasenia ingresada debe ser de 5 caracteres.");
            }
        }
    }
}
