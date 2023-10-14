using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class Conexion
    {

        private string Base;
        private string servidor;
        private string usuario;
        private string clave;

        private bool seguridad;

        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "Punto_Ventas";
            this.servidor = "LAPTOP-55SN3IUO";
            this.usuario = "sa";
            this.clave = "123";
            this.seguridad = true;
        }

        public SqlConnection crearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server =" + this.servidor + "; Database =" + this.Base + ";";
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id =" + this.usuario + "; Password=" + this.clave;
                }
            }
            catch (Exception ex) {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion crearInstancia()
        {
            if(con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
