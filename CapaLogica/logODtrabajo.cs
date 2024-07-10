using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidadd;

namespace CapaLogica
{
    public class logODtrabajo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logODtrabajo _instancia = new logODtrabajo();
        //privado para evitar la instanciación directa
        public static logODtrabajo Instancia
        {
            get
            {
                return logODtrabajo._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entODTrabajo> ListarOrdentrabajo()
        {
            return datODTrabajo.Instancia.ListarOdtrabajo();

        }
        public void Insertarordentrabajo(entODTrabajo Cli)
        {
             datODTrabajo.Instancia.Insertarordentrabajo(Cli);
        }

        #endregion metodos
    }
}
