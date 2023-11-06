using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class clientesSql
    {

        public DataTable listar_en_dataGrids(string consulta)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = consulta;
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

        public DataTable BuscarClientes(string nombre, string apellido)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Cliente where nombres like '%' + '" + nombre + "' +'%' or apellidos like '%' + '" + apellido + "' + '%'";
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

        public DataTable BuscarDocumento(string valor)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Documento where tipo like '%' + '" + valor + "' +'%'";
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

        public DataTable BuscarMunicipio(string valor)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Municipio where nombre like '%' + '" + valor + "' +'%'";
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



        public string Insertar(clientesObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Insert into Cliente (id_cliente, id_documento, id_municipio, no_documento, nit_cliente, nombres, apellidos, direccion, telefono, fecha_nacimiento, fecha_ingreso) " +
                    "values (" + "'" + obj.id_cliente + "'," + "'" + obj.id_documento+ "'," + "'" + obj.id_municipio + "'," + "'" + obj.noDocumento + "'," + "'" + obj.nit + "'," + 
                    "'" + obj.nombres + "'," + "'" + obj.apellidos + "'," + "'" + obj.direccion + "'," + "'"+obj.telefono+"'," + "'" + obj.fecha_nacimiento + "'," + "'" + obj.fecha_ingreso + "')";

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

        public string Actualizar(clientesObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Update Cliente set id_documento = '"+obj.id_documento+"', id_municipio = '"+obj.id_municipio + "', no_documento = '" + obj.noDocumento +
                    "', nombres = '" + obj.nombres + "', apellidos = '" + obj.apellidos + "', nit_cliente = '" + obj.nit +
                    "', direccion = '" + obj.direccion + "', telefono = '" + obj.telefono + "', fecha_nacimiento = '" + obj.fecha_nacimiento +
                    "', fecha_ingreso = '" + obj.fecha_ingreso + "' where id_cliente = '" + obj.id_cliente + "'";
                
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
                string sql = "Delete from Cliente where id_cliente = '" + Id + "'";
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

        public string ultimoId_Cliente()
        {

            string respuesta = "";

            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select max(id_cliente) from Cliente";

                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                respuesta += ex.Message;
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }

    }
}
