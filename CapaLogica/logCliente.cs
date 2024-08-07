﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using CapaEntidadd;
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

        #endregion singleton

        #region metodos

        ///listado

        public List<entCliente> ListarCliente()
        {
            return datCliente.Instancia.ListarCliente();

        }
        public List<entCliente> buscarclienteporid(int idcliente)
        {
            return datCliente.Instancia.Buscarclienteid(idcliente);
        }
        public void InsertarCliente(entCliente Cli)
        {
            datCliente.Instancia.InsertarCliente(Cli);
        }

        public void EditarCliente(entCliente Cli)
        {
            datCliente.Instancia.EditarCliente(Cli);
        }

        public void DeshabilitarCliente(entCliente Cli)
        {
            datCliente.Instancia.DeshabilitarCliente(Cli);
        }


        #endregion metodos
    }
}