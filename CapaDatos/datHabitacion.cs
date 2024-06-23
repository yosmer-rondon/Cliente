using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class datHabitacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datHabitacion _instancia = new datHabitacion();
        //privado para evitar la instanciación directa
        public static datHabitacion Instancia
        {
            get
            {
                return datHabitacion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Habitaciones
        public List<entHabitacion> ListarHabitacion()
        {
            SqlCommand cmd = null;
            List<entHabitacion> lista = new List<entHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new entHabitacion
                    {
                        ID = Convert.ToInt32(dr["IDHabitacion"]),
                        Piso = Convert.ToInt32(dr["PisoHabitacion"]),
                        IDTipo = Convert.ToInt32(dr["IDTipoHabitacion"]),
                        Capacidad = Convert.ToInt32(dr["CapacidadHabitacion"]),
                        Costo = Convert.ToDecimal(dr["CostoHabitacion"]),
                        Estado = Convert.ToBoolean(dr["EstadoHabitacion"])
                    });
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
        /////////////////////////Insertar Tipo Habitacion
        public bool InsertarTipoHabitacion(entHabitacion habitacion)
        {
            SqlCommand cmd = null;
            bool inserta = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@PisoHabitacion", habitacion.Piso);
                cmd.Parameters.AddWithValue("@IDTipoHabitacion", habitacion.IDTipo);
                cmd.Parameters.AddWithValue("@CapacidadHabitacion", habitacion.Capacidad);
                cmd.Parameters.AddWithValue("@CostoHabitacion", habitacion.Costo);
                cmd.Parameters.AddWithValue("@EstadoHabitacion", habitacion.Estado);

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


        //////////////////////////////////Editando Tipo Habitacion
        public bool EditarTipoHabitacion(entHabitacion habitacion)
        {
            SqlCommand cmd = null;
            bool edita = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDHabitacion", habitacion.ID);
                cmd.Parameters.AddWithValue("@PisoHabitacion", habitacion.Piso);
                cmd.Parameters.AddWithValue("@IDTipoHabitacion", habitacion.IDTipo);
                cmd.Parameters.AddWithValue("@CapacidadHabitacion", habitacion.Capacidad);
                cmd.Parameters.AddWithValue("@CostoHabitacion", habitacion.Costo);
                cmd.Parameters.AddWithValue("@EstadoHabitacion", habitacion.Estado);

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

        //////////////Deshabilitando Tipo de Habitacion

        public bool DeshabilitarTipoHabitacion(int idHabitacion)
        {
            SqlCommand cmd = null;
            bool deshabilitado = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDHabitacion", idHabitacion);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilitado = true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { cmd.Connection.Close(); }

            return deshabilitado;
        }
        #endregion metodos
    }
}
