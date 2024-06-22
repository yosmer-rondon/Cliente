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

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                int idMetodoPago = Convert.ToInt32(txtId.Text);
                logMetodoPago.Instancia.DeshabilitarMetodoPago(idMetodoPago);
                llenarDatos();
            }
            catch (Exception)
            {

                MessageBox.Show("No se pudo deshabilitar la Metodo de pago");
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvMetodoPago.Enabled = true;
            txtNomMetodoPago.Enabled = true;
            cbxActivo.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago fp = new entMetodoPago();
                fp.N_TPago = txtNomMetodoPago.Text;
                logMetodosPago.Instancia.InsertarMetodoPago(fp);
                llenarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los datos", "Error en los datos");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago fp = new entMetodoPago();
                fp.Id_MetodoPago = Convert.ToInt32(txtId.Text);
                fp.N_TPago = txtNomMetodoPago.Text;
                if (cbxActivo.Checked)
                {
                    fp.estMetodoPago = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 };
                }
                else
                {
                    fp.estMetodoPago = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                }
                logMetodoPago.Instancia.EditarMetodoPago(fp);
                MessageBox.Show("Se modifico la Metodo de pago");
                txtNomMetodoPago.Enabled = false;
                cbxActivo.Enabled = false;
                llenarDatos();
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique los datos", "Error en los datos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvMetodoPago.Enabled = false;
            txtNomMetodoPago.Enabled = false;
            cbxActivo.Checked = false;

        }
    }
}
