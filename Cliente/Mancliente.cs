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

namespace Cliente
{
    public partial class Mancliente : Form
    {
        public Mancliente()
        {
            InitializeComponent();
            listar();
            groupBox1.Enabled = false;
            textBox9.Enabled = false;


        }
        public void listar()
        {
            dataGridView1.DataSource = logCliente.Instancia.ListarCliente();    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = false;

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
            LimpiarVariables();
            btnModificar.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Nombre = textBox6.Text.Trim();
                c.Apellido = textBox11.Text.Trim();
                c.DNI = int.Parse(textBox12.Text.Trim());
                c.Telefono = int.Parse(textBox8.Text.Trim());
                c.TipoCliente = textBox10.Text.Trim();
                c.FechaRegistro = FechaRegistroCliente.Value;
                c.Correo = textBox7.Text.Trim();

                logCliente.Instancia.InsertarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listar();
        }
        private void LimpiarVariables()
        {
            textBox6.Text = "";
            textBox11.Text = " ";
            textBox10.Text = " ";
            textBox7.Text = " ";
            textBox12.Text = " ";
            textBox8.Text = " ";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.Nombre = textBox6.Text.Trim();
                c.Apellido = textBox11.Text.Trim();
                c.DNI = int.Parse(textBox12.Text.Trim());
                c.Telefono = int.Parse(textBox8.Text.Trim());
                c.TipoCliente = textBox10.Text.Trim();
                c.FechaRegistro = FechaRegistroCliente.Value;
                c.Correo = textBox7.Text.Trim();
                logCliente.Instancia.EditarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listar();

        }
    }
}

