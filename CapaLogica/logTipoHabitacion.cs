using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaLogica
{
    public class logTipoHabitacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoHabitacion _instancia = new logTipoHabitacion();
        //privado para evitar la instanciación directa
        public static logTipoHabitacion Instancia
        {
            get
            {
                return logTipoHabitacion._instancia;
            }
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        #endregion metodos
    }
}


