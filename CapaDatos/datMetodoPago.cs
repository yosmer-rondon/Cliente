using CapaEntidadd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datMetodoPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia.
        private static readonly datMetodoPago _instancia = new datMetodoPago();
        //privado para evitar la instanciación directa.
        public static datMetodoPago Instancia
        {
            get
            {
                return datMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        SqlConnection cn = Conexion.Instancia.Conectar();
        SqlCommand cmd = null;
        //Listar Metodo de Pago
        public List<entMetodoPago> listarMetodoPago()
        {
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                cmd = new SqlCommand("sp_ListarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entMetodoPago fp = new entMetodoPago();
                    fp.Id_MetodoPago = Convert.ToInt32(dr["Id_MetodoPago"]);
                    fp.N_TPago = dr["N_TPago"].ToString();
                    fp.estMetodoPago = (byte[])dr["estMetodoPago"];
                    lista.Add(fp);
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
        //Insertar Metodo de Pago
        public Boolean InsertarMetodoPago(entMetodoPago fp)
        {

            Boolean inserta = false;
            try
            {
                cmd = new SqlCommand("sp_InsertarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@N_TPago", fp.N_TPago);
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
        //Editar MetodoPago
        public Boolean EditarMetodoPago(entMetodoPago fp)
        {

            Boolean inserta = false;
            try
            {
                cmd = new SqlCommand("sp_EditarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_MetodoPago", fp.Id_MetodoPago);
                cmd.Parameters.AddWithValue("@N_TPago", fp.N_TPago);
                cmd.Parameters.AddWithValue("@estMetodoPago", fp.estMetodoPago);
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
        //Deshabilitar MetodoPago
        public Boolean DeshabilitarMetodoPago(int id)
        {
            Boolean delete = false;
            try
            {
                cmd = new SqlCommand("sp_DeshabilitarMetodoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_MetodoPago", id);
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
