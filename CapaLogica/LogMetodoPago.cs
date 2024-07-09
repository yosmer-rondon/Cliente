using CapaDatos;
using CapaEntidadd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMetodoPago
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        //privado para evitar la instanciación directa
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        public void Insertarmetodopago(entMetodoPago mep)
        {
            datMetodoPago.Instancia.Insertarmetodopago(mep);
        }

        //EDITAR
        public bool EditarMetodoPago(entMetodoPago cli)
        {
            return datMetodoPago.Instancia.EditarMetodoPago(cli);
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entMetodoPago> Listarmetodopago()
        {
            return datMetodoPago.Instancia.Listarmetodopago();
        }
        #endregion metodos

    }
}
