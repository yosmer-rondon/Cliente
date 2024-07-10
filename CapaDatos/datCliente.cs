using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;
namespace CapaDatos
{
    public class datCliente
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datCliente _instancia = new datCliente();
        //privado para evitar la instanciación directa
        public static datCliente Instancia
        {
            get
            {
                return datCliente._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entCliente> ListarCliente()
        {
            SqlCommand cmd = null;
            List<entCliente> lista = new List<entCliente>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listarcliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entCliente Cli = new entCliente();
                    Cli.id = Convert.ToInt32(dr["id"]);
                    Cli.nombre = dr["nombre"].ToString();
                    Cli.apellido = dr["apellido"].ToString();
                    Cli.dni = Convert.ToInt32(dr["dni"]);
                    Cli.telefono = Convert.ToInt32(dr["telefono"]);
                    Cli.correo = dr["correo"].ToString();
                    Cli.estado = dr["estado"].ToString();
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
        public Boolean InsertarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("agregarcliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@Apellido", Cli.apellido);
                cmd.Parameters.AddWithValue("@DNI", Cli.dni);
                cmd.Parameters.AddWithValue("@Telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@Correo", Cli.correo);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
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
        public Boolean EditarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCliente", Cli.id);
                cmd.Parameters.AddWithValue("@Nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@Apellido", Cli.apellido);
                cmd.Parameters.AddWithValue("@DNI", Cli.dni);
                cmd.Parameters.AddWithValue("@Telefono", Cli.telefono);
                cmd.Parameters.AddWithValue("@Correo", Cli.correo);
                cmd.Parameters.AddWithValue("@estado", Cli.estado);
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

        public Boolean DeshabilitarCliente(entCliente Cli)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("DeshabilitarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDCliente", Cli.id);
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


