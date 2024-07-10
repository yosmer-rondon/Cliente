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
            Id.Enabled = false;
        }
        public void listar()
        {
            dataGridView1.DataSource = logTipoTrabajo.Instancia.Listartipotrabajo();
        }
        private void LimpiarVariables()
        {
            Id.Text = "";
            nombre.Text = "";
            descripcion.Text = "";
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
            try
            {
                entTipoTrabajo c = new entTipoTrabajo();
                c.IDTipoTrabajo = int.Parse(Id.Text.Trim());
                c.nombre = nombre.Text.Trim();
                c.descripcion = descripcion.Text.Trim();
                c.estado = estado.Text.Trim();
                logTipoTrabajo.Instancia.Editartipotrabajo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoTrabajo c = new entTipoTrabajo();

                c.IDTipoTrabajo = int.Parse(Id.Text.Trim());
                logTipoTrabajo.Instancia.Deshabilitartipotrabajo(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex];
            Id.Text = filaActual.Cells[0].Value.ToString();
            nombre.Text = filaActual.Cells[1].Value.ToString();
            descripcion.Text = filaActual.Cells[2].Value.ToString();
            estado.Text = filaActual.Cells[3].Value.ToString();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
        }
    }
}
