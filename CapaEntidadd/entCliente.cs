﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class entCliente
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int Telefono { get; set; }
        public int IDtipocliente { get; set; } // IDtipocliente
        public DateTime FechaRegistro { get; set; }
        public string Correo { get; set; }

    }
}
