using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaLogica
{

    public class logCliente
    {

        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly logCliente _instancia = new logCliente();
        //privado para evitar la instanciación directa
        public static logCliente Instancia
        {
            get
            {
                return logCliente._instancia;
            }
        }
        ///inserta
        public void InsertaCliente(entCliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }

        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();
        }

        #endregion metodos
    }
}