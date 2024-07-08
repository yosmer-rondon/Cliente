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
    public class logTipoTrabajo
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logTipoTrabajo _instancia = new logTipoTrabajo();
        //privado para evitar la instanciación directa
        public static logTipoTrabajo Instancia
        {
            get
            {
                return logTipoTrabajo._instancia;
            }
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entTipoTrabajo> Listartipotrabajo()
        {
            return datTipotrabajo.Instancia.Listartipotrabajo();
        }
        public void Insertartipotrabajo(entTipoTrabajo ttra)
        {
            datTipotrabajo.Instancia.Insertartipotrabajo(ttra);
        }

        public void EditarCliente(entCliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }

        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }



        #endregion metodos
    }
}
