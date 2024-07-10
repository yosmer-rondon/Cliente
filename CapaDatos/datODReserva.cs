using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaEntidadd;

namespace CapaDatos
{
    public class datODReserva
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datODReserva _instancia = new datODReserva();
        //privado para evitar la instanciación directa
        public static datODReserva Instancia
        {
            get
            {
                return datODReserva._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entODReserva> Listarreserva()
        {
            SqlCommand cmd = null;
            List<entODReserva> lista = new List<entODReserva>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listarordenreserva", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entODReserva Cli = new entODReserva();
                    Cli.idODReserva = Convert.ToInt32(dr["id"]);
                    Cli.fecha_entrada = Convert.ToDateTime(dr["fecha_entrada"]);
                    Cli.fecha_salida = Convert.ToDateTime(dr["fecha_salida"]);
                    Cli.estado = dr["estado"].ToString(); ;
                    Cli.descripcion = dr["descripcion"].ToString();
                    Cli.costo = Convert.ToDouble(dr["costo"]);
                    Cli.idCliente = Convert.ToInt32(dr["cliente_id"]);
                    Cli.idMetodoPago = Convert.ToInt32(dr["metodo_pago_id"]);
                    Cli.idHabitacion = Convert.ToInt32(dr["habitacion_id"]);
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
        #endregion metodos
    }
}
