using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{

    public class Conexion
    {
        public string ser="";
        public string bd="";
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }
        //patron de diseño singleton
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source="+ser+"; Initial Catalog ="+bd+";" +//"User ID=sa; Password=123";
                                "Integrated Security=true";

            return cn;
        }

    }

}
