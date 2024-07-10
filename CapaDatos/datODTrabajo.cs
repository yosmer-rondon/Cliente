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
        public Boolean Insertarordenreserva(entODReserva Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("realizareserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@fecha_entrada", Cli.fecha_entrada);
                cmd.Parameters.AddWithValue("@fecha_salida", Cli.fecha_salida);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
                cmd.Parameters.AddWithValue("@descripcion", Cli.descripcion);
                cmd.Parameters.AddWithValue("@costo", Cli.costo);
                cmd.Parameters.AddWithValue("@cliente_id", Cli.idCliente);
                cmd.Parameters.AddWithValue("@nombre_metodo_pago", Cli.nombre_metpago);
                cmd.Parameters.AddWithValue("@num", Cli.num_habitacion);
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

        public void CulminarReserva(int idReserva)
        {
            SqlCommand cmd = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); // singleton
                cmd = new SqlCommand("culminarreserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_reserva", idReserva);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        #endregion metodos

    }
}
