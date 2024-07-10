using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadd;

namespace CapaDatos
{
    public class datODTrabajo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datODTrabajo _instancia = new datODTrabajo();
        //privado para evitar la instanciación directa
        public static datODTrabajo Instancia
        {
            get
            {
                return datODTrabajo._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entODTrabajo> ListarOdtrabajo()
        {
            SqlCommand cmd = null;
            List<entODTrabajo> lista = new List<entODTrabajo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listarordentrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entODTrabajo Cli = new entODTrabajo();
                    Cli.idODTrabajo= Convert.ToInt32(dr["id"]);
                    Cli.descripcion = dr["descripcion"].ToString();
                    Cli.estado = dr["estado"].ToString();
                    Cli.idTipoTrabajo = Convert.ToInt32(dr["tipo_trabajo_id"]); ;
                    Cli.idHabitacion = Convert.ToInt32(dr["Habitacion_id"]);
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
        public Boolean Insertarordentrabajo(entODTrabajo Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("ingresarodtrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", Cli.descripcion);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
                cmd.Parameters.AddWithValue("@nomtipo", Cli.nombretipo);
                cmd.Parameters.AddWithValue("@num", Cli.numhabitacion);
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

        #endregion metodos

    }
}
