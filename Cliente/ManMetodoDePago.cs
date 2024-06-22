using CapaLogica;
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
    public partial class ManMetodoDePago : Form
    {
        public ManMetodoDePago()
        {
            InitializeComponent();
        }
        private void ManMetodoPago_Load(object sender, EventArgs e)
        {
            llenarDatos();

        }
        public void llenarDatos()
        {
            dgvMetodoPago.Columns.Clear();
            dgvMetodoPago.AutoGenerateColumns = false;
            dgvMetodoPago.Columns.Add("Id_MetodoPago", "ID Metodo de Pago");
            dgvMetodoPago.Columns["Id_MetodoPago"].DataPropertyName = "Id_MetodoPago";
            dgvMetodoPago.Columns.Add("N_TPago", "Nombre Tipo de Pago");
            dgvMetodoPago.Columns["N_TPago"].DataPropertyName = "N_TPago";
            dgvMetodoPago.Columns.Add("Estado", "Estado");
            dgvMetodoPago.Columns["Estado"].DataPropertyName = "Estado";
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNomMetodoPago.Enabled = true;
            cbxActivo.Checked = true;
        }
    }
}
