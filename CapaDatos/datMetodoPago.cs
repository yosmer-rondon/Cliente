﻿using CapaEntidadd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datMetodoPago
    {
        #region sigleton
        //Patron Singleton.
        // Variable estática para la instancia.

        public static readonly datMetodoPago _instancia = new datMetodoPago();
        //privado para evitar la instanciación directa.
        public static datMetodoPago Instancia
        {
            get
            {
                return datMetodoPago._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entMetodoPago> Listarmetodopago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton.
                cmd = new SqlCommand("listarmetodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    entMetodoPago mep = new entMetodoPago();
                    mep.IDMetodopago = Convert.ToInt32(dr["id"]);
                    mep.nombre = dr["nombre"].ToString();
                    mep.descripcion = dr["descripcion"].ToString();
                    mep.estado = dr["estado"].ToString();
                    lista.Add(mep);

                }

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }
        /////////////////////////Insertando Cliente.

        public Boolean Insertarmetodopago(entMetodoPago mep)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Insertarmetodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", mep.nombre);
                cmd.Parameters.AddWithValue("@descripcion", mep.descripcion);
                cmd.Parameters.AddWithValue("@estado", mep.estado);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserta = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return inserta;
        }

        public Boolean Deshabilitarmetodopago(entMetodoPago Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarMetodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Cli.IDMetodopago);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    delete = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return delete;
        }

        public Boolean Editarmetodopago(entMetodoPago Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {

                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditartipoMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Cli.IDMetodopago);
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@descripcion", Cli.descripcion);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    edita = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }
            return edita;
        }

            public List<entMetodoPago> obtenernombresmetodopago()
            {
                SqlCommand cmd = null;
                List<entMetodoPago> lista = new List<entMetodoPago>();
                try
                {
                    SqlConnection cn = Conexion.Instancia.Conectar(); //singleton.
                    cmd = new SqlCommand("obtenernombresdemetodopago", cn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        entMetodoPago emp = new entMetodoPago();
                        emp.nombre = dr["nombre"].ToString();
                        lista.Add(emp);
                    }

                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    cmd.Connection.Close();
                }
                return lista;
            }
            #endregion metodos
        }
    }    

