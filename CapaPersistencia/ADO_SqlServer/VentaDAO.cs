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
    public class VentaDAO : IVenta
    {
        private GestorSQL gestorSQL;

        public VentaDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        //  GUARDAR VENTA

        public void guardar(Venta venta)
        {
            // CREANDO LAS SENTENCIAS SQL
            string insertarVentaSQL, actualizarProductoSQL;

            insertarVentaSQL = "INSERT INTO Venta(numeroDeSerie, numeroDeDocumento, fecha, total, idCliente, idProducto) " + "VALUES(@numeroDeSerie, @numeroDeDocumento, @fecha, @total, @idCliente, @idProducto)";
            actualizarProductoSQL = "UPDATE Producto SET stock = @stock WHERE idProducto = @idProducto";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO VENTA
                if (venta.Cliente != null)
                {
                    //  GUARDANDO LA VENTA

                    comando = gestorSQL.obtenerComandoSQL(insertarVentaSQL);
                    comando.Parameters.AddWithValue("@numeroDeSerie", venta.NumeroDeSerie);
                    comando.Parameters.AddWithValue("@numeroDeDocumento", venta.NumeroDeDocumento);
                    comando.Parameters.AddWithValue("@fecha", venta.Fecha);
                    comando.Parameters.AddWithValue("@total", venta.Total);
                    comando.Parameters.AddWithValue("@idCliente", venta.Cliente.IdCliente);
                    comando.Parameters.AddWithValue("@idProducto", venta.Producto.IdProducto);
                    comando.ExecuteNonQuery();

                    //  ACTUALIZANDO EL STOCK DEL PRODUCTO

                    comando = gestorSQL.obtenerComandoSQL(actualizarProductoSQL);
                    comando.Parameters.AddWithValue("@idProducto", venta.Producto.IdProducto);
                    comando.Parameters.AddWithValue("@stock", venta.Producto.Stock);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar.", err);
            }
        }

        //  OBTENER ULTIMO NUMERO DE DOCUMENTO

        public int obtenerUltimoNumeroDeDocumento()
        {
            int ultimoNumeroDeDocumento;
            string consultaSQL = "SELECT TOP 1 numeroDeDocumento FROM Venta ORDER BY idVenta DESC";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    ultimoNumeroDeDocumento = obtenerUltimoNumeroDeDocumentoDeLaUltimaVenta(resultadoSQL);
                    
                    if(ultimoNumeroDeDocumento == 99999999)
                    {
                        ultimoNumeroDeDocumento = 0;
                    }

                }
                else
                {
                    ultimoNumeroDeDocumento = 0;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return ultimoNumeroDeDocumento;
        }

        private int obtenerUltimoNumeroDeDocumentoDeLaUltimaVenta(SqlDataReader resultadoSQL)
        {
            Venta venta = new Venta();
            venta.NumeroDeDocumento = (resultadoSQL.GetInt32(0));
            return venta.NumeroDeDocumento;
        }

        //  LISTAR VENTAS

        public List<Venta> listarVentas()
        {
            List<Venta> listaDeVentas = new List<Venta>();
            Venta venta = new Venta();

            string consultaSQL = "SELECT idVenta, numeroDeSerie, numeroDeDocumento, fecha, total, idCliente, idProducto FROM Venta";

            try
            {
                SqlDataReader resultado = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultado.Read())
                {
                    venta = obtenerVenta(resultado);
                    listaDeVentas.Add(venta);
                }
                resultado.Close();
                return listaDeVentas;
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar listar los empleados", err);
            }
        }

        private Venta obtenerVenta(SqlDataReader resultadoSQL)
        {
            Venta venta = new Venta();
            Cliente cliente = new Cliente();
            Producto producto = new Producto();

            venta.IdVenta = resultadoSQL.GetInt32(0);
            venta.NumeroDeSerie = resultadoSQL.GetString(1);
            venta.NumeroDeDocumento = resultadoSQL.GetInt32(2);
            venta.Fecha = resultadoSQL.GetDateTime(3);
            venta.Total = resultadoSQL.GetDecimal(4);

            cliente.IdCliente = resultadoSQL.GetInt32(5);
            producto.IdProducto = resultadoSQL.GetInt32(6);

            venta.Cliente = cliente;
            venta.Producto = producto;

            return venta;
        }

    }
}
