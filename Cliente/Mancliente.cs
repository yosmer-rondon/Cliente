using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cliente
{
    public partial class Mancliente : Form
    {
        public Mancliente()
        {
            InitializeComponent();
            listar();
            groupBox1.Enabled = false;

        }
        public void listar()
        {
            dataGridView1.DataSource = logCliente.Instancia.ListarCliente();    
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Mancliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Enabled = true;
            btnAgregar.Visible = true;
            //LimpiarVariables();
            btnModificar.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grupBoxDatos1_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Nombre = txtRazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txtidTipoCliente.Text.Trim());
                c.fecRegCliente = dtPickerRegCliente.Value;
                c.idCiudad = int.Parse(txtidCiudad.Text.Trim());
                c.estCliente = cbkEstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatos.Enabled = false;
            listarCliente();
        }

    }

    private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
