using CapaDatos;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaEntidad;
using CapaEntidadd;

namespace Cliente
{
    public partial class manHabitaciones : Form
    {
        public manHabitaciones()
        {
            InitializeComponent();
            Listar();
            groupDatosHabitacion.Enabled = false;
            textIDHabitacion.Enabled = false;

        }

        public void Listar()
        {
            dgvHabitaciones.DataSource = logHabitacion.Instancia.ListarHabitacion();    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevaHabitacion_Click(object sender, EventArgs e)
        {
            groupDatosHabitacion.Enabled = true;

            btnAgregarHabitacion.Visible = true;
            //LimpiarVariables();
            btnModificarHabitacion.Visible = false;

        }

        private void btnAgregarHabitacion_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entHabitacion c = new entHabitacion();
                c.Habitacion = int.Parse(textHabitacion.Text.Trim());
                c.IDTipoHabitacion = int.Parse(comboBox1.Text.Trim());
                c.Piso = int.Parse(textPisoHabitacion.Text.Trim());
                c.Capacidad = textCapacidadHabitacion.Text.Trim();
                c.Costo = int.Parse(textCostoHabitacion.Text.Trim());
                c.Estado = textBox1.Text.Trim();
                logHabitacion.Instancia.InsertarHabiacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupDatosHabitacion.Enabled = false;
            Listar();
        }

        private void LimpiarVariables()
        {
            textHabitacion.Text = "";
            comboBox1.Text = " ";
            textPisoHabitacion.Text = " ";
            textCapacidadHabitacion.Text = " ";
            textCostoHabitacion.Text = " ";
            textBox1.Text = "";


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupDatosHabitacion.Enabled = false;
        }

        private void dgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvHabitaciones.Rows[e.RowIndex]; //
            textIDHabitacion.Text = filaActual.Cells[0].Value.ToString();
            textHabitacion.Text = filaActual.Cells[1].Value.ToString();
            comboBox1.Text = filaActual.Cells[2].Value.ToString();
            textPisoHabitacion.Text = filaActual.Cells[3].Value.ToString();
            textCapacidadHabitacion.Text = filaActual.Cells[4].Value.ToString();
            textCostoHabitacion.Text = filaActual.Cells[5].Value.ToString();
            textBox1.Text = filaActual.Cells[6].Value.ToString();

        }

        private void btnEditarHabitacion_Click(object sender, EventArgs e)
        {
            groupDatosHabitacion.Enabled = true;
            btnModificarHabitacion.Visible = true;
            btnAgregarHabitacion.Visible = false;

        }

        private void btnModificarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion c = new entHabitacion();
                c.IDHabitacion = int.Parse(textIDHabitacion.Text.Trim());
                c.Habitacion = int.Parse(textHabitacion.Text.Trim());
                c.IDTipoHabitacion = int.Parse(textIDTipoHabitacion.Text.Trim());
                c.Piso = int.Parse(textPisoHabitacion.Text.Trim());
                c.Capacidad = textCapacidadHabitacion.Text.Trim();
                c.Costo = int.Parse(textCostoHabitacion.Text.Trim());
                c.Estado = checkEstadoHabitacion.Checked;
                logHabitacion.Instancia.EditarHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupDatosHabitacion.Enabled = false;
            Listar();
        }

        private void btnDeshabilitarHabitacion_Click(object sender, EventArgs e)
        {
            try
            {
                entHabitacion c = new entHabitacion();

                c.IDHabitacion = int.Parse(textIDHabitacion.Text.Trim());
                logHabitacion.Instancia.DeshabilitarHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupDatosHabitacion.Enabled = false;
            Listar();
        }
    }
}

