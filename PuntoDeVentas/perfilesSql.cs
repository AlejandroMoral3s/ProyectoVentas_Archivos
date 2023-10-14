using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class perfilesSql
    {

        //BUSQUEDA EN DATA GRID

        public DataTable Buscar(string valor)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Perfil where nombre like '%' + '"+valor+"' +'%'";
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

        //LISTAR EN DATA GRID

        public DataTable Listar()
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Perfil";
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

        //INSERTAR NUEVOS REGISTROS

        public string Insertar(perfilesObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Insert into Perfil (id_perfil, nombre) values ("+"'"+obj.id+"'," + "'"+obj.nombre+"')";
                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK":"No se pudo ingresar el registro";

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

        //ACTUALIZAR LOS REGISTROS

        public string Actualizar(perfilesObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Update Perfil set nombre = '"+obj.nombre+"' where id_perfil = '"+obj.id+"'";
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

        //ELIMINAR REGISTROS

        public string Eliminar(int Id)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Delete from Perfil where id_perfil = '"+Id+"'";
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
