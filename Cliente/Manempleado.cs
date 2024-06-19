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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
                c.nombre = nombre.Text.Trim();
                c.tipoempleado = tipoempleado.Text.Trim();
                c.direccion = direccion.Text.Trim();
                c.Telefono = int.Parse(telefono.Text.Trim());
                c.correo = correo.Text.Trim();
                c.dni = int.Parse(dni.Text.Trim());
                c.fechareg = fecha.Value;

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
            nombre.Text = "";
            tipoempleado.Text = " ";
            direccion.Text = " ";
            telefono.Text = " ";
            correo.Text = " ";
            dni.Text = " ";
            telefono.Text = " ";
        }
        public void listar()
        {
            dataGridView1.DataSource = LogEmpleado.Instancia.ListarEmpleado();
        }
    }
}
