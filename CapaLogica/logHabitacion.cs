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
    public class logHabitacion
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logHabitacion _instancia = new logHabitacion();
        //privado para evitar la instanciación directa
        public static logHabitacion Instancia
        {
            get
            {
                return logHabitacion._instancia;
            }
        }

        //INSERTAR
        public bool InsertarHabitacion(entHabitacion habitacion)
        {
            return datHabitacion.Instancia.InsertarHabitacion(habitacion);
        }

        //EDITAR
        public bool EditarHabitacion(entHabitacion habitacion)
        {
            return datHabitacion.Instancia.EditarHabitacion(habitacion);
        }

        //DESHABILITAR
        public bool DeshabilitarHabitacion(entHabitacion Cli)
        {
            return datHabitacion.Instancia.DeshabilitarHabitacion(Cli);
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entHabitacion> ListarHabitacion()
        {
            return datHabitacion.Instancia.ListarHabitacion();
        }

        public List<entHabitacion> BuscarHabitacionPorId(int id)
        {
            return datHabitacion.Instancia.BuscarHabitacionPorId(id);
        }

        #endregion metodos
    }

}
