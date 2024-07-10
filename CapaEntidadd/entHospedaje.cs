using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class entHospedaje
    {
        public int id { get; set; }
        public int id_cliente { get; set; }
        public int id_habitacion { get; set; }
        public int id_metodo_pago { get; set; }
        public double costo { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public string estado { get; set; }
    }
}
