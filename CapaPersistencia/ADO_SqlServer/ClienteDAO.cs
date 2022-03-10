using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Entidades;
using CapaDominio.Contratos;
using System.Data.SqlClient;

namespace CapaPersistencia.ADO_SqlServer
{
    public class ClienteDAO : ICliente
    {
        private GestorSQL gestorSQL;

        public ClienteDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        //  GUARDAR CLIENTE

        public void guardarCliente(Cliente cliente)
        {
            // CREANDO LA SENTENCIA SQL
            string insertarClienteSQL;

            insertarClienteSQL = "INSERT INTO Cliente(dni, nombre, apellido, direccion) " +
                "VALUES(@dni, @nombre, @apellido, @direccion)";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO EMPLEADO
                comando = gestorSQL.obtenerComandoSQL(insertarClienteSQL);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar el cliente.", err);
            }
        }

        //  EDITAR CLIENTE

        public void editarCliente(Cliente cliente)
        {
            string actualizarClienteSQL;

            actualizarClienteSQL = "UPDATE Cliente SET dni = @dni, nombre = @nombre, apellido = @apellido, direccion = @direccion WHERE idCliente = @idCliente";
            try
            {
                SqlCommand comando;
                comando = gestorSQL.obtenerComandoSQL(actualizarClienteSQL);
                comando.Parameters.AddWithValue("@dni", cliente.Dni);
                comando.Parameters.AddWithValue("@nombre", cliente.Nombre);
                comando.Parameters.AddWithValue("@apellido", cliente.Apellido);
                comando.Parameters.AddWithValue("@direccion", cliente.Direccion);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar al cliente.", err);
            }
        }

        //  LISTAR CLIENTES

        public List<Cliente> listarClientes()
        {
            List<Cliente> listaDeClientes = new List<Cliente>();
            Cliente cliente = new Cliente();

            string consultaSQL = "SELECT idCliente, dni, nombre, apellido, direccion FROM Cliente";

            try
            {
                SqlDataReader resultado = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultado.Read())
                {
                    cliente = obtenerCliente(resultado);
                    listaDeClientes.Add(cliente);
                }
                resultado.Close();
                return listaDeClientes;
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar listar los clientes", err);
            }
        }

        //  BUSCAR POR DNI

        public Cliente buscarClientePorDni(string dni)
        {
            Cliente cliente;
            string consultaSQL = "SELECT idCliente, dni, nombre, apellido, direccion FROM Cliente WHERE dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cliente = obtenerCliente(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el cliente.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cliente;
        }

        private Cliente obtenerCliente(SqlDataReader resultadoSQL)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = resultadoSQL.GetInt32(0);
            cliente.Dni = resultadoSQL.GetString(1);
            cliente.Nombre = resultadoSQL.GetString(2);
            cliente.Apellido = resultadoSQL.GetString(3);
            cliente.Direccion = resultadoSQL.GetString(4);
            return cliente;
        }

        //  SELECCIONAR ULTIMO CLIENTE REGISTRADO

        public Cliente seleccionarUltimoClienteRegistrado()
        {
            Cliente cliente;
            string consultaSQL = "SELECT TOP 1 * FROM Cliente ORDER BY idCliente DESC";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cliente = obtenerCliente(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe o ocurrió un error al encontrar al último cliente registrado.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cliente;
        }

        //  BUSCAR CLIENTE POR ID

        public Cliente buscarClientePorId(int idCliente)
        {
            Cliente cliente;
            string consultaSQL = "SELECT idCliente, dni, nombre, apellido, direccion FROM Cliente WHERE idCliente = '" + idCliente + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    cliente = obtenerCliente(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el cliente.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return cliente;
        }

    }
}
