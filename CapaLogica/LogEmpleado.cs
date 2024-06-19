using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaEntidadd;

namespace CapaLogica
{
    public class LogEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogEmpleado _instancia = new LogEmpleado();
        //privado para evitar la instanciación directa
        public static LogEmpleado Instancia
        {
            get
            {
                return LogEmpleado._instancia;
            }
        }
        public void InsertarEmpleado(entEmpleado Cli)
        {
            datEmpleado.Instancia.InsertarEmpleado(Cli);
        }
            #endregion singleton

            #region metodos

            ///listado

        public List<entEmpleado> ListarEmpleado()
        {
                return datEmpleado.Instancia.ListarEmpleado();
        }

            #endregion metodos
        }
    }

