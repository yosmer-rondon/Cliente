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
    public partial class reservas : Form
    {
        public reservas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mancliente manc = new Mancliente();
            manc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pago pag = new Pago();
            pag.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
