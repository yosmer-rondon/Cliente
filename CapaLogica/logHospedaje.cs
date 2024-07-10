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
    public class logHospedaje
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logHospedaje _instancia = new logHospedaje();
        //privado para evitar la instanciación directa
        public static logHospedaje Instancia
        {
            get
            {
                return logHospedaje._instancia;
            }
        }

        //INSERTAR
        public bool InsertarHospedaje(entHospedaje cli)
        {
            return datHospedaje.Instancia.InsertarHospedaje(cli);
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entHospedaje> ListarHospedaje()
        {
            return datHospedaje.Instancia.ListarHospedaje();
        }

        #endregion metodos
    }
}
