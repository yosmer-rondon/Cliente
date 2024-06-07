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

namespace Cliente
{
    public partial class Mancliente : Form
    {
        public Mancliente()
        {
            InitializeComponent();
            listar();
        }
        public void listar()
        {
            dataGridView1.DataSource = datCliente.Instancia.ListarCliente();
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
    }
}
