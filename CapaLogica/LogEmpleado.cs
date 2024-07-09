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
    public class LogEmpleado
    {
        #region sigleton
        //Patron Singleton
        // Variable estática para la instancia
        private static readonly LogEmpleado _instancia = new LogEmpleado();
        //privado para evitar la instanciación directa
        public static LogEmpleado Instancia
        {
            get
            {
                return LogEmpleado._instancia;
            }
        }


        #endregion singleton

        #region metodos

        public void InsertarEmpleado(entEmpleado Cli)
        {
            datEmpleado.Instancia.InsertarEmpleado(Cli);
        }

        //EDITA
        public void EditarEmpleado(entEmpleado Cli)
        {
            datEmpleado.Instancia.EditarEmpleado(Cli);
        }

        ///listado

        public List<entEmpleado> ListarEmpleado()
        {
                return datEmpleado.Instancia.ListarEmpleado();
        }
        public void Deshabilitarempleado(entEmpleado Cli)
        {
            datEmpleado.Instancia.Deshabilitarempleado(Cli);
        }
        public List<entEmpleado> BuscarEmpleadoPorId(int idEmpleado)
        {
            return datEmpleado.Instancia.BuscarEmpleadoPorId(idEmpleado);
        }
        #endregion metodos
    }
    }

