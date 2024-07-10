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
    public class datHospedaje
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datHospedaje _instancia = new datHospedaje();
        //privado para evitar la instanciación directa
        public static datHospedaje Instancia
        {
            get
            {
                return datHospedaje._instancia;
            }
        }
        #endregion singleton

        #region metodos

        public List<entHospedaje> ListarHospedaje()
        {
            SqlCommand cmd = null;
            List<entHospedaje> lista = new List<entHospedaje>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListarHospedaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entHospedaje Cli = new entHospedaje();
                    Cli.id = Convert.ToInt32(dr["id"]);
                    Cli.id_cliente = Convert.ToInt32(dr["id_cliente"]);
                    Cli.id_habitacion = Convert.ToInt32(dr["id_habitacion"]);
                    Cli.id_metodo_pago = Convert.ToInt32(dr["id_metodo_pago"]);
                    Cli.costo = Convert.ToDouble(dr["costo"]);
                    Cli.fecha_entrada = Convert.ToDateTime(dr["fecha_entrada"]);
                    Cli.fecha_salida = Convert.ToDateTime(dr["fecha_salida"]);
                    Cli.estado = Convert.ToString(dr["estado"]);
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
        public Boolean InsertarHospedaje(entHospedaje Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("RealizarHospedaje", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cliente", Cli.id_cliente);
                cmd.Parameters.AddWithValue("@costo", Cli.costo);
                cmd.Parameters.AddWithValue("@fecha_entrada", Cli.fecha_entrada);
                cmd.Parameters.AddWithValue("@fecha_salida", Cli.fecha_salida);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
                cmd.Parameters.AddWithValue("@num_habitacion", Cli.num_habitacion);
                cmd.Parameters.AddWithValue("@nombre_metpago", Cli.nombre_metpago);
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
