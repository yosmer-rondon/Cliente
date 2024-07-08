using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaEntidadd;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cliente
{
    public partial class ManTipoTrabajo : Form
    {
        public ManTipoTrabajo()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            dataGridView1.DataSource = logTipoTrabajo.Instancia.Listartipotrabajo();
        }
        private void LimpiarVariables()
        {
            nombre.Text = "";
            descripcion.Text = " ";
            estado.Text = " ";
        }

        private void ManTipoTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoTrabajo t = new entTipoTrabajo();
                t.nombre = nombre.Text.Trim();
                t.descripcion = descripcion.Text.Trim();
                t.estado = estado.Text.Trim();
                logTipoTrabajo.Instancia.Insertartipotrabajo(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
          

        }

        private void buttonLista_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonEliminar_Click(object sender, EventArgs e)
        {
           
        }


    }
}
