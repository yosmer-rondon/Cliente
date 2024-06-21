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

        public void InsertarTipoHabitacion(entTipoHabitacion Cli)
        {
            datTipoHabitacion.Instancia.InsertarTipoHabitacion(Cli);
        }

        public void EditarTipoHabitacion(entTipoHabitacion Cli)
        {
            datTipoHabitacion.Instancia.EditarTipoHabitacion(Cli);
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entTipoHabitacion> ListarTipoHabitacion()
        {
            return datTipoHabitacion.Instancia.ListarTipoHabitacion();
        }

        #endregion metodos
    }
}


