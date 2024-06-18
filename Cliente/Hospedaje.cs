using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Hospedaje : Form
    {
        public Hospedaje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reservas res = new reservas();
            res.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pago pag = new Pago();
            pag.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
