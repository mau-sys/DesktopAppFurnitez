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
    public class ProductoDAO : IProducto
    {
        private GestorSQL gestorSQL;

        public ProductoDAO(IGestorAccesoDatos gestorSQL)
        {
            this.gestorSQL = (GestorSQL)gestorSQL;
        }

        //  GUARDAR PRODUCTO

        public void guardarProducto(Producto producto)
        {
            // CREANDO LA SENTENCIA SQL
            string insertarProductoSQL;

            insertarProductoSQL = "INSERT INTO Producto(nombre,precio,stock,tipo) " +
                "VALUES(@nombre,@precio,@stock,@tipo)";

            try
            {
                SqlCommand comando;

                // GUARDANDO EL OBJETO EMPLEADO
                comando = gestorSQL.obtenerComandoSQL(insertarProductoSQL);
                comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.Parameters.AddWithValue("@stock", producto.Stock);
                comando.Parameters.AddWithValue("@tipo", producto.Tipo);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar el producto.", err);
            }
        }

        //  EDITAR PRODUCTO

        public void editarProducto(Producto producto)
        {
            string actualizarProductoSQL;

            actualizarProductoSQL = "UPDATE Producto SET nombre = @nombre, precio = @precio, stock = @stock, tipo = @tipo WHERE idProducto = @idProducto";
            try
            {
                SqlCommand comando;
                comando = gestorSQL.obtenerComandoSQL(actualizarProductoSQL);
                comando.Parameters.AddWithValue("@idProducto", producto.IdProducto);
                comando.Parameters.AddWithValue("@nombre", producto.Nombre);
                comando.Parameters.AddWithValue("@precio", producto.Precio);
                comando.Parameters.AddWithValue("@stock", producto.Stock);
                comando.Parameters.AddWithValue("@tipo", producto.Tipo);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar guardar el producto.", err);
            }
        }

        //  LISTAR PRODUCTOS

        public List<Producto> listarProductos()
        {
            List<Producto> listaDeProductos = new List<Producto>();
            Producto producto = new Producto();

            string consultaSQL = "SELECT idProducto, nombre, precio, stock, tipo FROM Producto";

            try
            {
                SqlDataReader resultado = gestorSQL.ejecutarConsulta(consultaSQL);

                while (resultado.Read())
                {
                    producto = obtenerProducto(resultado);
                    listaDeProductos.Add(producto);
                }
                resultado.Close();
                return listaDeProductos;
            }
            catch (Exception err)
            {
                throw new Exception("Ocurrio un problema al intentar listar los productos", err);
            }
        }

        private Producto obtenerProducto(SqlDataReader resultadoSQL)
        {
            Producto producto = new Producto();
            producto.IdProducto = resultadoSQL.GetInt32(0);
            //producto.Codigo = resultadoSQL.GetString(0);
            producto.Nombre = resultadoSQL.GetString(1);
            producto.Precio = resultadoSQL.GetDecimal(2);
            producto.Stock = resultadoSQL.GetInt32(3);
            producto.Tipo = resultadoSQL.GetString(4);
            return producto;
        }

        //  BUSCAR PRODUCTOS POR NOMBRE

        public List<Producto> buscarProductosPorNombre(string nombre)
        {
            List<Producto> listaDeProductos = new List<Producto>();
            Producto producto;
            string consultaSQL = "SELECT * FROM Producto WHERE nombre like '%" + nombre + "%' order by nombre";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                while (resultadoSQL.Read())
                {
                    producto = obtenerProducto(resultadoSQL);
                    listaDeProductos.Add(producto);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listaDeProductos;
        }

        //  BUSCAR PRODUCTOS POR CODIGO

        public Producto buscarPorCodigo(int codigo)
        {
            Producto producto;
            string consultaSQL = "SELECT * FROM Producto WHERE idProducto = '" + codigo + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    producto = obtenerProducto(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el producto.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return producto;
        }

        //  ELIMINAR PRODUCTO

        public void eliminarProducto(int idProducto)
        {
            string consultaSQL = "DELETE FROM Producto WHERE idProducto = " + idProducto;

            try
            {
                SqlCommand comando;
                comando = gestorSQL.obtenerComandoSQL(consultaSQL);
                comando.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        //  BUSCAR PRODUCTO POR ID

        public Producto buscarProductoPorId(int idProducto)
        {
            Producto producto;
            string consultaSQL = "SELECT * FROM Producto WHERE idProducto = '" + idProducto + "'";
            try
            {
                SqlDataReader resultadoSQL = gestorSQL.ejecutarConsulta(consultaSQL);
                if (resultadoSQL.Read())
                {
                    producto = obtenerProducto(resultadoSQL);
                }
                else
                {
                    throw new Exception("No existe el producto.");
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return producto;
        }
    }
}
