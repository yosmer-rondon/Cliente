using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidadd;

namespace CapaLogica
{
    public class logTipoEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoEmpleado _instancia = new logTipoEmpleado();
        //privado para evitar la instanciación directa
        public static logTipoEmpleado Instancia
        {
            get
            {
                return logTipoEmpleado._instancia;
            }
        }

      
        
        #endregion singleton

        #region metodos
        public List<entTipoEmpleado> ListarTipoEmpleado()
        {
            return datTipoEmpleado.Instancia.ListarTipoEmpleado();
        }
        public List<entTipoEmpleado> listarnombrestipos()
        {
            return datTipoEmpleado._instancia.nombredetipos();
        }

        public List<entTipoEmpleado> bucarnombresconidtipo(int id_tipocliente)
        {
            return datTipoEmpleado._instancia.bucarnombreconidtipoempleado(id_tipocliente);
        }
        public void InsertarTipoEmpleado(entTipoEmpleado temp)
        {
            datTipoEmpleado.Instancia.InsertarTipoEmpleado(temp);
        }

        //EDITAR
        public void EditarTipoHabitacion(entTipoEmpleado temp)
        {
            datTipoEmpleado.Instancia.EditarTipoempleado(temp);
        }


        public void Deshabilitartipoempleado(entTipoEmpleado temp)
        {
            datTipoEmpleado.Instancia.Deshabilitartipoempleado(temp);
        }
        #endregion metodos
    }
}
