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
            nombre.Text = "";
            descripcion.Text = " ";
            estado.Text = " ";
        }
    }
}
