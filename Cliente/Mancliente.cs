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
            ID_cliente.Enabled = false;


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
                c.nombre = nombre.Text.Trim();
                c.apellido = apellidos.Text.Trim();
                c.dni = int.Parse(dni.Text.Trim());
                c.telefono = int.Parse(telefono.Text.Trim());
                c.correo = correo.Text.Trim();
                c.estado = estado.Text.Trim();
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
            nombre.Text = "";
            apellidos.Text = " ";
            estado.Text = " ";
            correo.Text = " ";
            dni.Text = " ";
            telefono.Text = " ";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.id = int.Parse(ID_cliente.Text.Trim());
                c.nombre = nombre.Text.Trim();
                c.apellido = apellidos.Text.Trim();
                c.dni = int.Parse(dni.Text.Trim());
                c.telefono = int.Parse(telefono.Text.Trim());
                c.correo = correo.Text.Trim();
                c.estado = estado.Text.Trim();
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dataGridView1.Rows[e.RowIndex];
            ID_cliente.Text = filaActual.Cells[0].Value.ToString();
            nombre.Text = filaActual.Cells[1].Value.ToString();
            apellidos.Text = filaActual.Cells[2].Value.ToString();
            dni.Text = filaActual.Cells[3].Value.ToString();
            telefono.Text = filaActual.Cells[4].Value.ToString();
            correo.Text = filaActual.Cells[5].Value.ToString();
            estado.Text = filaActual.Cells[6].Value.ToString();
            //cbkEstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();

                c.id = int.Parse(ID_cliente.Text.Trim());
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBox1.Enabled = false;
            listar();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }
    }
}

