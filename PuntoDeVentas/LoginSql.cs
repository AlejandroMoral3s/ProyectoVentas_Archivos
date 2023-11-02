using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class LoginSql
    {
        public string checklogin(string us, string pass)
        {
            string respuesta = "";

            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "select id_perfil from Usuario where '" + us + "' = nombre_usuario and '" + pass + "' = clave";

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
        public string getIdUsuario(string us)
        {
            string respuesta = "";

            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "select id_usuario from Usuario where '" + us + "' = nombre_usuario" ;

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
