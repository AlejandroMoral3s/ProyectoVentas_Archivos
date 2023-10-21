using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class productosSql
    {

        public DataTable ListarIvas()
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Iva";
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public DataTable ListarProductos()
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Producto";
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public DataTable BuscarProductos(string valor)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Producto where nombre like '%' + '" + valor + "' +'%'";
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public DataTable BuscarIvas(string valor)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Iva where nombre like '%' + '" + valor + "' +'%'";
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                lista = comando.ExecuteReader();
                Tabla.Load(lista);
                return Tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        public string Insertar(productosObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Insert into Producto (id_producto, id_iva, nombre, precio, nota) " +
                    "values (" + "'" + obj.id_producto + "'," + "'" + obj.id_iva + "'," + "'" + obj.nombre_producto + "'," + "" + obj.precio + "," + "'" + obj.nota + "')";

                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }

        public string Actualizar(productosObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Update Producto set id_iva = '" + obj.id_iva + "', nombre = '" + obj.nombre_producto + "', precio = '" + obj.precio +
                    "', nota = '" + obj.nota  + "' where id_producto = '" + obj.id_producto+ "'";
               
                
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }

        public string Eliminar(int Id)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Delete from Producto where id_producto = '" + Id + "'";
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }

    }
}
