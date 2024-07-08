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
        // Variable estática para la instancia
 yolvin1
        public static readonly datMetodoPago _instancia = new datMetodoPago();
        //privado para evitar la instanciación directa
        public static datMetodoPago Instancia
        {
            get
            {
                return datMetodoPago._instancia;
        public static readonly datTipotrabajo _instancia = new datTipotrabajo();
        //privado para evitar la instanciación directa
        public static datTipotrabajo Instancia
        {
            get
            {
                return datTipotrabajo._instancia; master
            }
        }
        #endregion singleton

        #region metodos
    ///////////////////listado d Clientes
 yolvin1
        public List<entMetodoPago> Listarmetodopago()
        {
            SqlCommand cmd = null;
            List<entMetodoPago> lista = new List<entMetodoPago>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listarmetodopago", cn);

        public List<entTipoTrabajo> Listartipotrabajo()
        {
            SqlCommand cmd = null;
            List<entTipoTrabajo> lista = new List<entTipoTrabajo>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listartipotrabajo", cn);
 master
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
 yolvin1
                    entMetodoPago mep = new entMetodoPago();
                    mep.IDMetodopago = Convert.ToInt32(dr["id"]);
                    mep.nombre = dr["nombre"].ToString();
                    mep.descripcion = dr["descripcion"].ToString();
                    mep.estado = dr["estado"].ToString();
                    lista.Add(mep);

                    entTipoTrabajo ttra = new entTipoTrabajo();
                    ttra.IDTipoTrabajo = Convert.ToInt32(dr["id"]);
                    ttra.nombre = dr["nombre"].ToString();
                    ttra.descripcion = dr["descripcion"].ToString();
                    ttra.estado = dr["estado"].ToString();
                    lista.Add(ttra);
 master
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

        public Boolean Insertarmetodopago(entMetodoPago mep)

        public Boolean Insertartipotrabajo(entTipoTrabajo ttra) m
          aster
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
 yolvin1
                cmd = new SqlCommand("Insertarmetodopago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", mep.nombre);
                cmd.Parameters.AddWithValue("@descripcion", mep.descripcion);
                cmd.Parameters.AddWithValue("@estado", mep.estado);

                cmd = new SqlCommand("Insertartipotrabajo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", ttra.nombre);
                cmd.Parameters.AddWithValue("@descripcion", ttra.descripcion);
                cmd.Parameters.AddWithValue("@estado", ttra.estado);
 master
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
