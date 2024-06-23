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
        // Variable estática para la instancia.
        private static readonly logMetodoPago _instancia = new logMetodoPago();
        //privado para evitar la instanciación directa.
        public static logMetodoPago Instancia
        {
            get
            {
                return logMetodoPago._instancia;
            }
        }
        #endregion singleton
        #region metodos
        public List<entMetodoPago> ListarMetodoPago()
        {
            return datMetodoPago.Instancia.listarMetodoPago();
        }
        public void InsertarMetodoPago(entMetodoPago fp)
        {
            datMetodoPago.Instancia.InsertarMetodoPago(fp);
        }
        public void EditarMetodoPago(entMetodoPago fp)
        {
            datMetodoPago.Instancia.EditarMetodoPago(fp);
        }
        public void DeshabilitarMetodoPago(int id)
        {
            datMetodoPago.Instancia.DeshabilitarMetodoPago(id);
        }
        #endregion metodos
    }
}
