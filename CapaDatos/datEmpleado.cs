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
                cmd = new SqlCommand("ListarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entEmpleado emp = new entEmpleado();
                    emp.Idempleado = Convert.ToInt32(dr["id"]);
                    emp.nombre = dr["nombre"].ToString();
                    emp.apellidos = dr["apellidos"].ToString();
                    emp.direccion = dr["direccion"].ToString();
                    emp.Telefono = Convert.ToInt32(dr["telefono"]);
                    emp.correo = dr["correo"].ToString();
                    emp.dni = Convert.ToInt32(dr["dni"]);
                    emp.estado = dr["estado"].ToString();
                    emp.idtipoempledo = dr["tipo_empleado_id"].ToString();
                    emp.Idempleado = Convert.ToInt32(dr["tipo_empleado_id"]);
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
        /////////////////////////Insertar Empleado
        public Boolean InsertarEmpleado(entEmpleado emp)
        {
            SqlCommand cmd = null;
            Boolean inserta = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("InsertarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", emp.nombre);
                cmd.Parameters.AddWithValue("@apellidos", emp.apellidos);
                cmd.Parameters.AddWithValue("@direccion", emp.direccion);
                cmd.Parameters.AddWithValue("@telefono", emp.Telefono);
                cmd.Parameters.AddWithValue("@correo", emp.correo);
                cmd.Parameters.AddWithValue("@dni", emp.dni);
                cmd.Parameters.AddWithValue("@estado", emp.estado);
                cmd.Parameters.AddWithValue("@nombre_tipo", emp.nombre_tipo);
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
        public Boolean EditarEmpleado(entEmpleado Cli)
        {
            SqlCommand cmd = null;
            Boolean edita = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spEditarEmpleado", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Idempleado", Cli.Idempleado);
                cmd.Parameters.AddWithValue("@nombre", Cli.nombre);
                cmd.Parameters.AddWithValue("@direccion", Cli.direccion);
                cmd.Parameters.AddWithValue("@telefono", Cli.Telefono);
                cmd.Parameters.AddWithValue("@correo", Cli.correo);
                cmd.Parameters.AddWithValue("@dni", Cli.dni);
                cmd.Parameters.AddWithValue("@dni", Cli.estado);
                cmd.Parameters.AddWithValue("@dni", Cli.idtipoempledo);
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
