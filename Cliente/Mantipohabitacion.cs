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
    public partial class Mantipohabitacion : Form
    {
        public Mantipohabitacion()
        {
            InitializeComponent();
            listar();
            groupBoxDatosTipoHabitacion.Enabled = false;
            IDTipoHabitacion.Enabled = false;
        }

        public void listar()
        {
            dgvTipoHabitacion.DataSource = logTipoHabitacion.Instancia.ListarTipoHabitacion();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxDatosTipoHabitacion.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoTipo_Click(object sender, EventArgs e)
        {
            groupBoxDatosTipoHabitacion.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Visible = true;
            //LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               entTipoHabitacion c = new entTipoHabitacion();
                c.Nombre = NombreTipo.Text.Trim();
                c.Vistas = Descripcion.Text.Trim();
                c.Costo = int.Parse(textCosto.Text.Trim());


                logTipoHabitacion.Instancia.InsertarTipoHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            //LimpiarVariables();
            groupBoxDatosTipoHabitacion.Enabled = false;
            listar();
        }
        private void LimpiarVariables()
        {
            NombreTipo.Text = "";
            Descripcion.Text = " ";
            textCosto.Text = " ";
            checkBoxEstadoTipo.Text = " ";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatosTipoHabitacion.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvTipoHabitacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow filaActual = dgvTipoHabitacion.Rows[e.RowIndex]; //
            IDTipoHabitacion.Text = filaActual.Cells[0].Value.ToString();
            NombreTipo.Text = filaActual.Cells[1].Value.ToString();
            Descripcion.Text = filaActual.Cells[2].Value.ToString();
            textCosto.Text = filaActual.Cells[3].Value.ToString();
            checkBoxEstadoTipo.Checked = Convert.ToBoolean(filaActual.Cells[4].Value);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoHabitacion c = new entTipoHabitacion();
                c.IDTipoHabitacion = int.Parse(IDTipoHabitacion.Text.Trim());
                c.Nombre = NombreTipo.Text.Trim();
                c.Vistas = Descripcion.Text.Trim();
                c.Costo = int.Parse(textCosto.Text.Trim());;
                c.Estado = textBox1.Text.Trim();
                logTipoHabitacion.Instancia.EditarTipoHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatosTipoHabitacion.Enabled = false;
            listar();

        }

        private void btnDeshabilitarTipo_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoHabitacion c = new entTipoHabitacion();

                c.IDTipoHabitacion = int.Parse(IDTipoHabitacion.Text.Trim());
                logTipoHabitacion.Instancia.DeshabilitarTipoHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatosTipoHabitacion.Enabled = false;
            listar();


        }

        private void groupBoxDatosTipoHabitacion_Enter(object sender, EventArgs e)
        {

        }

        private void textNombreTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
