using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaEntidadd;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente
{
    public partial class Manempleado : Form
    {
        public Manempleado()
        {
            InitializeComponent();
            listar();
            groupBox1.Enabled = false;
            textIDEmpleado.Enabled = false;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.nombre = textNombre.Text.Trim();
                c.tipoempleado = texttipoempleado.Text.Trim();
                c.direccion = textdireccion.Text.Trim();
                c.Telefono = int.Parse(texttelefono.Text.Trim());
                c.correo = textcorreo.Text.Trim();
                c.dni = int.Parse(textdni.Text.Trim());
                c.fechareg = dtfechareg.Value;

                LogEmpleado.Instancia.InsertarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            listar();
        
        }
        private void LimpiarVariables()
        {
            textNombre.Text = "";
            texttipoempleado.Text = " ";
            textdireccion.Text = " ";
            texttelefono.Text = " ";
            textcorreo.Text = " ";
            textdni.Text = " ";
            texttelefono.Text = " ";
        }
        public void listar()
        {
            dgvEmpleado.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manempleado_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex]; //
            textIDEmpleado.Text = filaActual.Cells[0].Value.ToString();
            textNombre.Text = filaActual.Cells[1].Value.ToString();
            texttipoempleado.Text = filaActual.Cells[2].Value.ToString();
            textdireccion.Text = filaActual.Cells[3].Value.ToString();
            texttelefono.Text = filaActual.Cells[4].Value.ToString();
            textcorreo.Text = filaActual.Cells[5].Value.ToString();
            textdni.Text = filaActual.Cells[6].Value.ToString();
            dtfechareg.Text = filaActual.Cells[7].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado c = new entEmpleado();
                c.Idempleado = int.Parse(textIDEmpleado.Text.Trim());
                c.nombre = textNombre.Text.Trim();
                c.tipoempleado = texttipoempleado.Text.Trim();
                c.direccion = textdireccion.Text.Trim();
                c.Telefono = int.Parse(texttelefono.Text.Trim());
                c.correo = textcorreo.Text.Trim();
                c.dni = int.Parse(textdni.Text.Trim());
                c.fechareg = dtfechareg.Value;
                LogEmpleado.Instancia.EditarEmpleado(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
