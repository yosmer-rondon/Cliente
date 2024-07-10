using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    public class entODReserva
    {
        public int idODReserva { get; set; }
        public DateTime fecha_entrada { get; set; }
        public DateTime fecha_salida { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }
        public string nombre_metpago { get; set; }
        public int idCliente { get; set; }
        public int idHabitacion { get; set; }
        public int idMetodoPago { get; set; }
        public double costo { get; set; }
        public int num_habitacion{ get; set; }
    }
}
