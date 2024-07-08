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
    public class datTipotrabajo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datTipotrabajo _instancia = new datTipotrabajo();
        //privado para evitar la instanciación directa
        public static datTipotrabajo Instancia
        {
            get
            {
                return datTipotrabajo._instancia;
            }
        }
        #endregion singleton

        #region metodos
        ////////////////////listado de Clientes
        public List<entTipoTrabajo> Listartipotrabajo()
        {
            SqlCommand cmd = null;
            List<entTipoTrabajo> lista = new List<entTipoTrabajo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listartipotrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoTrabajo ttra = new entTipoTrabajo();
                    ttra.IDTipoTrabajo = Convert.ToInt32(dr["id"]);
                    ttra.nombre = dr["nombre"].ToString();
                    ttra.descripcion = dr["descripcion"].ToString();
                    ttra.estado = dr["estado"].ToString();
                    lista.Add(ttra);
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
        public Boolean Insertartipotrabajo(entTipoTrabajo ttra)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Insertartipotrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", ttra.nombre);
                cmd.Parameters.AddWithValue("@descripcion", ttra.descripcion);
                cmd.Parameters.AddWithValue("@estado", ttra.estado);
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
                cmd = new SqlCommand("spEditarCliente", cn);
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
                cmd = new SqlCommand("spDeshabilitarCliente", cn);
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
