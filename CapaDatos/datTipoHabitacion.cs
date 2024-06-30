using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaEntidadd;



namespace CapaDatos
{
    public class datTipoHabitacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datTipoHabitacion _instancia = new datTipoHabitacion();
        //privado para evitar la instanciación directa
        public static datTipoHabitacion Instancia
        {
            get
            {
                return datTipoHabitacion._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Tipo de Habitaciones
        public List<entTipoHabitacion> ListarTipoHabitacion()
        {
            SqlCommand cmd = null;
            List<entTipoHabitacion> lista = new List<entTipoHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoHabitacion Cli = new entTipoHabitacion();
                    Cli.IDTipoHabitacion = Convert.ToInt32(dr["IDTipoHabitacion"]);
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.Vistas = dr["Vistas"].ToString();
                    Cli.Costo = Convert.ToInt32(dr["Costo"]);
                    Cli.Estado = (dr["Estado"]).ToString();
                    lista.Add(Cli);
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
        public Boolean InsertarTipoHabitacion(entTipoHabitacion Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Vistas", Cli.Vistas);
                cmd.Parameters.AddWithValue("@Costo", Cli.Costo);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
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
        public Boolean EditarTipoHabitacion(entTipoHabitacion Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTipoHabitacion", Cli.IDTipoHabitacion);
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Vistas", Cli.Vistas);
                cmd.Parameters.AddWithValue("@Costo", Cli.Costo);
                cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
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

        public Boolean DeshabilitarTipoHabitacion(entTipoHabitacion Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spDeshabilitarTipoHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDTipoHabitacion", Cli.IDTipoHabitacion);
                //cmd.Parameters.AddWithValue("@Estado", Cli.Estado);
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
        #endregion metodos
    }
}


