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
    public class datEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datEmpleado _instancia = new datEmpleado();
        //privado para evitar la instanciación directa
        public static datEmpleado Instancia
        {
            get
            {
                return datEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Empleados
        public List<entEmpleado> ListarEmpleado()
        {
            SqlCommand cmd = null;
            List<entEmpleado> lista = new List<entEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("spListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado Cli = new entEmpleado();
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.tipoempleado = dr["tipoempleado"].ToString();
                    Cli.direccion = dr["direccion"].ToString();
                    Cli.Telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.correo = dr["correo"].ToString();
                    Cli.dni = Convert.ToInt32(dr["dni"]);
                    Cli.fechareg = Convert.ToDateTime(dr["fechareg"]);
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
        /////////////////////////Insertar Empleado
        public Boolean InsertarEmpleado(entEmpleado Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spInsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@tipoempleado", Cli.tipoempleado);
                cmd.Parameters.AddWithValue("@direccion", Cli.direccion);
                cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@correo", Cli.correo);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@fechareg", Cli.fechareg);
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
        //////////////////////////////////Editando Empleado
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCliente", Cli.IDCliente);
                cmd.Parameters.AddWithValue("@Nombre", Cli.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", Cli.Apellido);
                cmd.Parameters.AddWithValue("@DNI", Cli.DNI);
                cmd.Parameters.AddWithValue("@Telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@TipoCliente", Cli.TipoCliente);
                cmd.Parameters.AddWithValue("@FechaRegistro", Cli.FechaRegistro);
                cmd.Parameters.AddWithValue("@Correo", Cli.Correo);
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
        #endregion metodos
    }
}
