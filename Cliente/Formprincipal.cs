using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaLogica;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cliente
{
    public partial class Formprincipal : Form
    {
        public Formprincipal()
        {
            InitializeComponent();
        }
        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string servidor = comboBox1.Text;
            string baseDatos = comboBox2.Text;
            CapaDatos.Conexion.Instancia.ser = servidor;
            CapaDatos.Conexion.Instancia.bd = baseDatos;
            label3.Text = "se conecto correctamente";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manempleado em = new Manempleado();
            em.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mancliente clie = new Mancliente();
            clie.Show();
        }

        private void Formprincipal_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manhabitacion mah = new Manhabitacion();
            mah.Show();
        }
    }
}
