using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class ReporteFacturasSql
    {

        public DataTable buscarNit(string nit)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            { // f.id_usuario  -->> convertir a -- >> select ( concat(nombre, ' ', apellido)) from Usuario) as id_producto
                string sql = "select f.id_factura, f.id_usuario, f.fecha_emision, f.id_cliente, f.total_factura " +
                    "from Factura f join Cliente c on f.id_cliente = c.id_cliente where c.nit_cliente = '"+nit+"'";
                
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

        public DataTable buscarFecha(string fecha)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Factura where fecha_emision = '"+fecha+"'";
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

        public DataTable buscarProducto(string nombre_producto)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "select f.id_factura, f.id_usuario, f.fecha_emision, f.id_cliente, f.total_factura " +
                    "from Factura f join Detalle_factura df on f.id_factura = df.id_factura " +
                    "join Producto p on df.id_producto = p.id_producto where p.nombre = '"+nombre_producto+"'";
                
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

        public DataTable buscarDetalles(int id_factura)
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "select df.id_factura, (select nombre from Producto where id_producto = df.id_producto) as nombre_producto, df.cantidad, df.subtotal " +
                    "from Detalle_factura df where df.id_factura = '"+id_factura+"'";
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

        public DataTable Listar_facturas()
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Factura";
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

    }
}
