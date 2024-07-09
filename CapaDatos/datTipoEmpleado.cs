using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidadd;

namespace CapaDatos
{
    public class datTipoEmpleado
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datTipoEmpleado _instancia = new datTipoEmpleado();
        //privado para evitar la instanciación directa
        public static datTipoEmpleado Instancia
        {
            get
            {
                return datTipoEmpleado._instancia;
            }
        }
        #endregion singleton
        #region metodos
        ////////////////////listado de Empleados
        public List<entTipoEmpleado> ListarTipoEmpleado()
        {
            SqlCommand cmd = null;
            List<entTipoEmpleado> lista = new List<entTipoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("ListartípoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEmpleado temp = new entTipoEmpleado();
                    temp.IDTipoEmpleado = Convert.ToInt32(dr["id"]);
                    temp.nombre = dr["nombre"].ToString();
                    temp.descripcion = dr["descripcion"].ToString();
                    temp.estado = dr["estado"].ToString();
                    lista.Add(temp);
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
        public Boolean InsertarTipoEmpleado(entTipoEmpleado temp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", temp.nombre);
                cmd.Parameters.AddWithValue("@descripcion", temp.descripcion);
                cmd.Parameters.AddWithValue("@estado", temp.estado);
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
        public Boolean EditarTipoempleado(entTipoEmpleado temp)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("EditarTipoEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", temp.IDTipoEmpleado);
                cmd.Parameters.AddWithValue("@nombre", temp.nombre);
                cmd.Parameters.AddWithValue("@descripcion", temp.descripcion);
                cmd.Parameters.AddWithValue("@estado", temp.estado);
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
        public List<entTipoEmpleado> nombredetipos()
        {
            SqlCommand cmd = null;
            List<entTipoEmpleado> lista = new List<entTipoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("listartiposdeempleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEmpleado emp = new entTipoEmpleado();
                    emp.nombre = dr["nombre"].ToString();
                    lista.Add(emp);
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
        public List<entTipoEmpleado> bucarnombreconidtipoempleado(int id_tipocliente)
        {
            SqlCommand cmd = null;
            List<entTipoEmpleado> lista = new List<entTipoEmpleado>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar(); //singleton
                cmd = new SqlCommand("BUCANOMBRETIPOEMPLEADO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_tipocliente", id_tipocliente);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entTipoEmpleado temp = new entTipoEmpleado();
                    temp.nombre = dr["nombre"].ToString();
                    lista.Add(temp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (cmd != null && cmd.Connection != null)
                {
                    cmd.Connection.Close();
                }
            }
            return lista;
        }
        #endregion metodos
    }
}
