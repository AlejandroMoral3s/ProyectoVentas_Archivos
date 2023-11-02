using System;
using System.Data;
using System.Data.SqlClient;

namespace PuntoDeVentas
{
    public class CambioClaveSql
    {

        public string Actualizar(string user, string clave, string confirmacion)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "UPDATE Usuario SET clave = '" + clave + "', confirmacion = '" + confirmacion + "' WHERE nombre_usuario = '" + user + "'";

                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "Clave no actualizada";

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

        public string buscarUser(string user)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "select id_usuario from Usuario where nombre_usuario='" + user + "'";

                con = Conexion.crearInstancia().crearConexion();
                SqlCommand comando = new SqlCommand(sql, con);
                con.Open();
                respuesta = comando.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                respuesta = "Usuario no encontrado";
            }
            finally
            {
                if (con.State == ConnectionState.Open) con.Close();
            }
            return respuesta;
        }





    }
}
