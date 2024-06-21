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
        ////////////////////listado de Clientes
        public List<entTipoHabitacion> ListarTipoHabitacion()
        {
            SqlCommand cmd = null;
            List<entTipoHabitacion> lista = new List<entTipoHabitacion>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.IDCliente = Convert.ToInt32(dr["IDCliente"]);
                    Cli.Nombre = dr["Nombre"].ToString();
                    Cli.Apellido = dr["Apellido"].ToString();
                    Cli.DNI = Convert.ToInt32(dr["DNI"]);
                    Cli.Telefono = Convert.ToInt32(dr["Telefono"]);
                    Cli.TipoCliente = dr["TipoCliente"].ToString();
                    Cli.FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"]);
                    Cli.Correo = dr["Correo"].ToString();
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


