using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class entHabitacion
    {
        public int id { get; set; }
        public int numhabitacion { get; set; }
        public int piso { get; set; }
        public int capacidad { get; set; }
        public double costo { get; set; }
        public string estado { get; set; }
        public string nombre { get; set; }
        public int tipo_habitacion_id { get; set; }
    }
}
