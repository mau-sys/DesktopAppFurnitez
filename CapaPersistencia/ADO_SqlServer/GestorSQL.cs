using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio.Contratos;
using System.Data.SqlClient;
using System.Data;

namespace CapaPersistencia.ADO_SqlServer
{
    public class GestorSQL : IGestorAccesoDatos
    {
        private SqlConnection conexion;
        private SqlTransaction transaccion;

        //  ABRIR CONEXION SQL

        public void abrirConexion()
        {
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = (local); Initial Catalog = FURNITEZ_DB; Integrated Security = true";
                conexion.Open();
            }
            catch (Exception err)
            {
                throw new Exception("Error en la conexión con la Base de Datos.", err);
            }
        }

        //  CERRAR CONEXION SQL

        public void cerrarConexion()
        {
            try
            {
                conexion.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cerrar la conexión con la Base de Datos.", err);
            }

        }

        //  INICIAR TRANSACCION SQL

        public void iniciarTransaccion()
        {
            try
            {
                abrirConexion();
                transaccion = conexion.BeginTransaction();
            }
            catch (Exception err)
            {
                throw new Exception("Error al iniciar la transacción con la Base de Datos.", err);
            }
        }

        //  TERMINAR TRANSACCION SQL

        public void terminarTransaccion()
        {
            try
            {
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al terminar la transacción con la Base de Datos.", err);
            }
        }

        //  CANCELAR TRANSACCION SQL

        public void cancelarTransaccion()
        {
            try
            {
                transaccion.Rollback();
                conexion.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Error al cancelar la transacción con la Base de Datos.", err);
            }
        }

        //  EJECUTAR CONSULTA SQL

        public SqlDataReader ejecutarConsulta(string sentenciaSQL)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL.ExecuteReader();
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar consulta en la Base de Datos.", err);
            }
        }

        //  OBTENER COMANDO SQL

        public SqlCommand obtenerComandoSQL(string sentenciaSQL)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = sentenciaSQL;
                comandoSQL.CommandType = CommandType.Text;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }

        //  OBTENER COMANDO DE PROCEDIMIENTO SQL

        public SqlCommand obtenerComandoDeProcedimiento(string procedimientoAlmacenado)
        {
            try
            {
                SqlCommand comandoSQL = conexion.CreateCommand();
                if (transaccion != null)
                    comandoSQL.Transaction = transaccion;
                comandoSQL.CommandText = procedimientoAlmacenado;
                comandoSQL.CommandType = CommandType.StoredProcedure;
                return comandoSQL;
            }
            catch (Exception err)
            {
                throw new Exception("Error al ejecutar comando en la Base de Datos.", err);
            }
        }

    }
}
