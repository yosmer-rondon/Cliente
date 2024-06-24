using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            dataGridView1.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manempleado_Load(object sender, EventArgs e)
        {

        }
    }
}
