﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVentas
{
    public class documentoSql
    {

        public DataTable Buscar(string valor)
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

        //LISTAR EN DATA GRID

        public DataTable Listar()
        {
            SqlDataReader lista;
            DataTable Tabla = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select * from Documento where id_documento > 1";
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

        public string Insertar(documentoObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Insert into Documento (id_documento, tipo) values (" + "'" + obj.id_documento + "'," + "'" + obj.tipo + "')";
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

        //ACTUALIZAR LOS REGISTROS

        public string Actualizar(documentoObj obj)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Update Documento set tipo = '" + obj.tipo + "' where id_documento = '" + obj.id_documento + "'";
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
                string sql = "Delete from Documento where id_documento = '" + Id + "'";
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


        public string ultimoId_Documento()
        {

            string respuesta = "";

            SqlConnection con = new SqlConnection();
            try
            {
                string sql = "Select max(id_documento) from Documento";

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
