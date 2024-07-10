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

        //INSERTAR
        public void InsertarTipoHabitacion(entTipoHabitacion Cli)
        {
            datTipoHabitacion.Instancia.InsertarTipoHabitacion(Cli);
        }

        //EDITAR
        public void EditarTipoHabitacion(entTipoHabitacion Cli)
        {
            datTipoHabitacion.Instancia.EditarTipoHabitacion(Cli);
        }

        //DESHABILITAR
        public void DeshabilitarTipoHabitacion(entTipoHabitacion Cli)
        {
            datTipoHabitacion.Instancia.DeshabilitarTipoHabitacion(Cli);
        }

        public List<entTipoHabitacion> nombrestipohabitacion()
        {
            return datTipoHabitacion.Instancia.nombrestipohabitacion();
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entTipoHabitacion> ListarTipoHabitacion()
        {
            return datTipoHabitacion.Instancia.ListarTipoHabitacion();
        }

        public List<entTipoHabitacion> bucarnombreconidtipohabitacion(int id)
        {
            return datTipoHabitacion._instancia.bucarnombreconidtipohabitacion(id);
        }

        #endregion metodos
    }
}


