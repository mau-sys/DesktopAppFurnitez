using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface IEmpleado
    {
        void guardarEmpleado(Empleado empleado);
        void editarEmpleado(Empleado empleado);
        List<Empleado> listarEmpleados();
        Empleado buscarEmpleadoPorDni(string dni);
    }
}
