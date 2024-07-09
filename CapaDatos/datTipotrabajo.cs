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
        public Boolean Editartipotrabajo(entTipoTrabajo ttra)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Editartipotrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ttra.IDTipoTrabajo);
                cmd.Parameters.AddWithValue("@Nombre", ttra.nombre);
                cmd.Parameters.AddWithValue("@descripcion", ttra.descripcion);
                cmd.Parameters.AddWithValue("@estado", ttra.estado);
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

        public Boolean Deshabilitartipotrabajo(entTipoTrabajo ttra)
        {
            SqlCommand cmd = null;
            Boolean delete = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("Deshabilitartipotrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", ttra.IDTipoTrabajo);
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
