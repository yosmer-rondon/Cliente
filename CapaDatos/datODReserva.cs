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
                    Cli.costo = Convert.ToDouble(dr["correo"]);
                    Cli.idCliente = Convert.ToInt32(dr["estado"]);
                    Cli.idMetodoPago = Convert.ToInt32(dr["estado"]);
                    Cli.idHabitacion = Convert.ToInt32(dr["estado"]);
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
