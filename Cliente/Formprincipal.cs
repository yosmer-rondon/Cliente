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
            manHabitaciones mah = new manHabitaciones();
            mah.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Mantipohabitacion tih = new Mantipohabitacion();
            tih.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ManMetodoDePago metp = new ManMetodoDePago();
            metp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RealizaOrdenReserva res = new RealizaOrdenReserva();
            res.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RealizaOrdenHospedaje hos = new RealizaOrdenHospedaje();
            hos.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MantipoEmpleado mtp = new MantipoEmpleado();
            mtp.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ManTipoTrabajo ttra = new ManTipoTrabajo();
            ttra.Show();
        }
    }
}
