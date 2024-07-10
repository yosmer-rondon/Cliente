using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
using CapaEntidadd;

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
                cmd = new SqlCommand("ListarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHabitacion Cli = new entHabitacion();
                    Cli.id = Convert.ToInt32(dr["id"]);
                    Cli.numhabitacion = Convert.ToInt32(dr["numhabitacion"]);
                    Cli.piso = Convert.ToInt32(dr["piso"]);
                    Cli.capacidad = Convert.ToInt32(dr["capacidad"]);
                    Cli.costo = Convert.ToDouble(dr["costo"]);
                    Cli.estado = dr["estado"].ToString();
                    Cli.tipo_habitacion_id = Convert.ToInt32(dr["tipo_habitacion_id"]);
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
        /////////////////////////Insertando Cliente
        public Boolean InsertarHabitacion(entHabitacion Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("AgregarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numhabitacion", Cli.numhabitacion);
                cmd.Parameters.AddWithValue("@piso", Cli.piso);
                cmd.Parameters.AddWithValue("@capacidad", Cli.capacidad);
                cmd.Parameters.AddWithValue("@costo", Cli.costo);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
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

        //////////////////////////////////Editando Cliente
        public Boolean EditarHabitacion(entHabitacion Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Cli.id);
                cmd.Parameters.AddWithValue("@numhabitacion", Cli.numhabitacion);
                cmd.Parameters.AddWithValue("@piso", Cli.piso);
                cmd.Parameters.AddWithValue("@capacidad", Cli.capacidad);
                cmd.Parameters.AddWithValue("@costo", Cli.costo);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
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
        ///////////////////////// Deshabilitando Cliente

        public Boolean DeshabilitarHabitacion(entHabitacion
            Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarHabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", Cli.id);
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

        public List<entHabitacion> BuscarHabitacionPorId(int id)
        {
            SqlCommand cmd = null;
            List<entHabitacion> lista = new List<entHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("bucarhabitacion", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHabitacion emp = new entHabitacion
                    {
                        id = Convert.ToInt32(dr["id"]),
                        numhabitacion = Convert.ToInt32(dr["numhabitacion"]),
                        piso = Convert.ToInt32(dr["piso"]),
                        capacidad = Convert.ToInt32(dr["capacidad"]),
                        costo = Convert.ToInt32(dr["costo"]),
                        estado = dr["estado"].ToString(),
                        tipo_habitacion_id = Convert.ToInt32(dr["tipo_habitacion_id"])
                    };
                    lista.Add(emp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }

        public List<entHabitacion> habitacionesdisponibles()
        {
            SqlCommand cmd = null;
            List<entHabitacion> lista = new List<entHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("habitacionesdisponibles", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHabitacion Cli = new entHabitacion();
                    Cli.id = Convert.ToInt32(dr["id"]);
                    Cli.numhabitacion = Convert.ToInt32(dr["numhabitacion"]);
                    Cli.piso = Convert.ToInt32(dr["piso"]);
                    Cli.capacidad = Convert.ToInt32(dr["capacidad"]);
                    Cli.costo = Convert.ToDouble(dr["costo"]);
                    Cli.estado = dr["estado"].ToString();
                    Cli.tipo_habitacion_id = Convert.ToInt32(dr["tipo_habitacion_id"]);
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
        #endregion metodos
    }
}