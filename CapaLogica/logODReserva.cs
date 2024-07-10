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
    public class logODReserva
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logODReserva _instancia = new logODReserva();
        //privado para evitar la instanciación directa
        public static logODReserva Instancia
        {
            get
            {
                return logODReserva._instancia;
            }
        }

        #endregion singleton

        #region metodos

        public List<entODReserva> ListarOrdenreserva()
        {
            return datODReserva.Instancia.Listarreserva();

        }
        public void Insertarordenreserva(entODReserva Cli)
        {
            datODReserva.Instancia.Insertarordenreserva(Cli);
        }

        #endregion metodos
    }
}
