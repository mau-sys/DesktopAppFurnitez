using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;

namespace CapaDominio.Contratos
{
    public interface ICliente
    {
        void guardarCliente(Cliente cliente);
        void editarCliente(Cliente cliente);
        List<Cliente> listarClientes();
        Cliente buscarClientePorDni(string dni);
        Cliente seleccionarUltimoClienteRegistrado();
        Cliente buscarClientePorId(int idCliente);
    }
}
