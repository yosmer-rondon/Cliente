using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class entMetodoPago
    {
        public int Id_MetodoPago { get; set; }
        public string N_TPago { get; set; }
        public byte[] estMetodoPago { get; set; }
        public string Estado
        {
            get
            {
                if (estMetodoPago != null && estMetodoPago.Length >= 1)
                {
                    return estMetodoPago[estMetodoPago.Length - 1] == 1 ? "Activo" : "Inactivo";
                }
                return "Inactivo";
            }
        }
    }
}
