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
    public class EmpleadoDAO : IEmpleado
    {
        private GestorSQL gestorSQL;

        public EmpleadoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        //  GUARDAR EMPLEADO

        public void guardarEmpleado(Empleado empleado)
        {
            // CREANDO LA SENTENCIA SQL
            string insertarEmpleadoSQL;

            insertarEmpleadoSQL = "INSERT INTO Empleado(nombre,apellido,dni,contrasenia,estado) " +
                "VALUES(@nombre,@apellido,@dni,@contrasenia,@estado)";

            try
            {
                SqlCommand comando;
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                // GUARDANDO EL OBJETO EMPLEADO
                comando = gestorSQL.obtenerComandoSQL(insertarEmpleadoSQL);
                comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@dni", empleado.Dni);
                comando.Parameters.AddWithValue("@contrasenia", empleado.Contrasenia);
                comando.Parameters.AddWithValue("@estado", empleado.Estado);
                //comando.Parameters.AddWithValue("@foto", empleado.Foto);
                //comando.Parameters["@foto"].Value = ms.GetBuffer();
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar el empleado.", err);
            }
        }

        //  EDITAR EMPLEADO

        public void editarEmpleado(Empleado empleado)
        {
            string actualizarEmpleadoSQL;

            actualizarEmpleadoSQL = "UPDATE Empleado SET nombre = @nombre, apellido = @apellido, dni = @dni, contrasenia = @contrasenia, estado = @estado WHERE dni = @dni";
            try
            {
                SqlCommand comando;
                comando = gestorSQL.obtenerComandoSQL(actualizarEmpleadoSQL);
                comando.Parameters.AddWithValue("@nombre", empleado.Nombre);
                comando.Parameters.AddWithValue("@apellido", empleado.Apellido);
                comando.Parameters.AddWithValue("@dni", empleado.Dni);
                comando.Parameters.AddWithValue("@contrasenia", empleado.Contrasenia);
                comando.Parameters.AddWithValue("@estado", empleado.Estado);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar al empleado.", err);
            }
        }

        //  LISTAR EMPLEADOS

        public List<Empleado> listarEmpleados()
        {
            List<Empleado> listaDeEmpleados = new List<Empleado>();
            Empleado empleado = new Empleado();

            string consultaSQL = "SELECT idEmpleado, nombre, apellido, dni, contrasenia, estado FROM Empleado";
            
            try
            {
                SqlDataReader resultado = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultado.Read())
                {
                    empleado = obtenerEmpleado(resultado);
                    listaDeEmpleados.Add(empleado);
                }
                resultado.Close();
                return listaDeEmpleados;
            }
            catch(Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar listar los empleados", err);
            }
        }

        //  BUSCAR EMPLEADO POR DNI

        public Empleado buscarEmpleadoPorDni(string dni)
        {
            Empleado empleado;
            string consultaSQL = "SELECT idEmpleado, nombre, apellido, dni, contrasenia, estado FROM Empleado WHERE dni = '" + dni + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    empleado = obtenerEmpleado(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el empleado.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return empleado;
        }

        private Empleado obtenerEmpleado(SqlDataReader resultadoSQL)
        {
            Empleado empleado = new Empleado();
            empleado.IdEmpleado = resultadoSQL.GetInt32(0);
            empleado.Nombre = resultadoSQL.GetString(1);
            empleado.Apellido = resultadoSQL.GetString(2);
            empleado.Dni = resultadoSQL.GetString(3);
            empleado.Contrasenia = resultadoSQL.GetString(4);
            empleado.Estado = resultadoSQL.GetBoolean(5);
            //empleado.Foto = resultadoSQL.GetByte(6);
            return empleado;
        }

    }
}
