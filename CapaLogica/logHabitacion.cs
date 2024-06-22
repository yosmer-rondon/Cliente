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
        public void InsertarHabiacion(entHabitacion Cli)
        {
            datHabitacion.Instancia.InsertarHabitacion(Cli);
        }

        //EDITAR
        public void EditarHabitacion(entHabitacion Cli)
        {
            datHabitacion.Instancia.EditarHabitacion(Cli);
        }

        //DESHABILITAR
        public void DeshabilitarHabitacion(entHabitacion Cli)
        {
            datHabitacion.Instancia.DeshabilitarHabitacion(Cli);
        }
        #endregion singleton

        #region metodos

        ///listado

        public List<entHabitacion> ListarHabitacion()
        {
            return datHabitacion.Instancia.ListarHabitacion();
        }

        #endregion metodos
    }

}
