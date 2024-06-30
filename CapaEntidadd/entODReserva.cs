using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidadd
{
    internal class entODReserva
    {
        public int idODReserva { get; set; }
        public int idCliente { get; set; }
        public int idHabitacion { get; set; }
        public int idMetodoPago { get; set; }
        public DateTime fecha_reserva { get; set; }
        public DateTime fecha_atencion { get; set; }
        public string estado { get; set; }
        public string descripcion { get; set; }

    }
}
