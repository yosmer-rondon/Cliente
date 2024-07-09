using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class MantipoEmpleado : Form
    {
        public MantipoEmpleado()
        {
            InitializeComponent();
            Listar();
            id.Enabled = false;

        }
        public void Listar()
        {

            dataGridView1.DataSource = logTipoEmpleado.Instancia.ListarTipoEmpleado();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEmpleado ted = new entTipoEmpleado();
                ted.nombre = nombre.Text.Trim();
                ted.descripcion = descripcion.Text.Trim();
                ted.estado = estado.Text.Trim();
                logTipoEmpleado.Instancia.InsertarTipoEmpleado(ted);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            Listar();
        }
        private void LimpiarVariables()
        {
            id.Text = "";
            nombre.Text = "";
            descripcion.Text = " ";
            estado.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEmpleado c = new entTipoEmpleado();
                c.IDTipoEmpleado = int.Parse(id.Text.Trim());
                c.nombre = nombre.Text.Trim();
                c.descripcion = descripcion.Text.Trim();
                c.estado = estado.Text.Trim();
                logTipoEmpleado.Instancia.EditarTipoHabitacion(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            Listar();
        }

        private void deshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoEmpleado c = new entTipoEmpleado();
                c.IDTipoEmpleado = int.Parse(id.Text.Trim());
                logTipoEmpleado.Instancia.Deshabilitartipoempleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            Listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex];
            id.Text = filaActual.Cells[0].Value.ToString();
            nombre.Text = filaActual.Cells[1].Value.ToString();
            descripcion.Text = filaActual.Cells[2].Value.ToString();
            estado.Text = filaActual.Cells[3].Value.ToString();
        }
    }
}
