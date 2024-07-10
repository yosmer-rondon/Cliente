using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datODReserva
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        public static readonly datODReserva _instancia = new datODReserva();
        //privado para evitar la instanciación directa
        public static datODReserva Instancia
        {
            get
            {
                return datODReserva._instancia;
            }
        }
        #endregion singleton

    }
}
