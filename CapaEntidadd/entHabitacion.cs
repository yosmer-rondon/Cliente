using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class entHabitacion
    {
        public int ID { get; set; }
        public int id_tipo_habitacion { get; set; }
        public int numero { get; set; }
        public int piso { get; set; }
        public int Capacidad { get; set; }
        public decimal Costo { get; set; }
        public bool Estado { get; set; }
    }
}
